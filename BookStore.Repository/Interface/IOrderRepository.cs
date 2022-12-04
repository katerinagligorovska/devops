using BookStore.Domain.Entity;

namespace BookStore.Repository.Interface
{
    public interface IOrderRepository : IRepository<Order>
    {
        List<Order> GetAllOrdersForUser(string userId);
        public Order GetOrderDetails(Order model);
    }
}
