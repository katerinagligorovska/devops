using BookStore.Domain.Identity;

namespace BookStore.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<EShopAppUser> GetAll();
        EShopAppUser Get(string id);
        void Insert(EShopAppUser entity);
        void Update(EShopAppUser entity);
        void Delete(EShopAppUser entity);
    }
}
