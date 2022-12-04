using BookStore.Domain.Entity;
using BookStore.Domain.Identity;
using BookStore.Repository.Interface;
using BookStore.Service.Interface;
using Microsoft.AspNetCore.Identity;

namespace BookStore.Service.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUserRepository _userRepository;
        private readonly UserManager<EShopAppUser> userManager;

        public OrderService(IOrderRepository orderRepository, IUserRepository userRepository, UserManager<EShopAppUser> userManager)
        {
            this._orderRepository = orderRepository;
            this._userRepository = userRepository;
            this.userManager = userManager;
        }

        public IEnumerable<Order> GetAllUserOrders(string userId)
        {
            var loggedInUser = this._userRepository.Get(userId);
            var roles = userManager.GetRolesAsync(loggedInUser);
            if (roles.Result.Contains(RoleName.Admin))
            {
                return this._orderRepository.GetAll();
            }
            return this._orderRepository.GetAllOrdersForUser(userId);
        }

        public Order GetOrderDetails(Guid model)
        {
            return this._orderRepository.Get(model);
        }
    }
}
