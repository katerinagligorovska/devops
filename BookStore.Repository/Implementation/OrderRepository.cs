using BookStore.Domain.Entity;
using BookStore.Domain.Relations;
using BookStore.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository.Implementation
{

    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private DbSet<Order> entities;

        public OrderRepository(ApplicationDbContext context) : base(context)
        {
            entities = context.Set<Order>();
        }
        public List<Order> GetAllOrders()
        {
            return entities
                .Include(z => z.User)
                .Include(z => z.BooksInOrder)
                .ToList();
        }
        public List<Order> GetAllOrdersForUser(string userId)
        {
            return entities
                .Include(z => z.User)
                .Include(z => z.BooksInOrder)
                .ThenInclude(b=>b.Book)
                .Where(p => p.UserId == userId)
                .ToList();
        }

        public Order GetOrderDetails(Guid orderId)
        {
            return entities
                .Include(z => z.User)
                .Include(z => z.BooksInOrder)
                .ThenInclude(b => b.Book)
                .Single(z => z.Id == orderId);

        }
    }
}
