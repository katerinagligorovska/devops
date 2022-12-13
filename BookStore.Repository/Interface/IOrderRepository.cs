using BookStore.Domain.Entity;

namespace BookStore.Repository.Interface
{
    public interface IOrderRepository : IRepository<Order>
    {
         List<Order> GetAllOrdersForUser(string userId);
         Order GetOrderDetails(Guid orderId);
         List<Order> GetAllOrders();
    }
}
