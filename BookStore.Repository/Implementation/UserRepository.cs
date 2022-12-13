using BookStore.Domain.Identity;
using BookStore.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<EShopAppUser> entities;

        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<EShopAppUser>();
        }

        public IEnumerable<EShopAppUser> GetAll()
        {
            return entities
                .Include(z => z.Cart)
                .ToList();
        }

        public EShopAppUser Get(string id)
        {
            return entities
               .Include(z => z.Cart)
               .ThenInclude(c => c.BookInShoppingCarts)
               .ThenInclude(b => b.CurrentBook)
               .Single(s => s.Id == id);
        }
        public void Insert(EShopAppUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(EShopAppUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }

        public void Delete(EShopAppUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}
