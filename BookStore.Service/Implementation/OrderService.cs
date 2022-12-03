using BookStore.Domain.Entity;
using BookStore.Domain.Identity;
using BookStore.Domain;
using BookStore.Repository.Interface;
using BookStore.Service.Interface;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<Order> getAllOrders(string userId)
        {
            var loggedInUser = this._userRepository.Get(userId);
            var roles = userManager.GetRolesAsync(loggedInUser);
            if (roles.Result[0] == RoleName.Admin)
            {
                return this._orderRepository.getAllOrders();
            }
            return this._orderRepository.getAllOrdersForUser(userId);
        }

        public Order getOrderDetails(BaseEntity model)
        {
            return this._orderRepository.getOrderDetails(model);
        }
    }
}
