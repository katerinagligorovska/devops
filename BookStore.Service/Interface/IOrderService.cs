using BookStore.Domain.Entity;

namespace BookStore.Service.Interface
{
    public interface IOrderService
    {
        List<Order> GetAllUserOrders(string userId);
        public Order GetOrderDetails(Guid orderId);
    }
}
