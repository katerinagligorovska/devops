using BookStore.Domain.Identity;

namespace BookStore.Service.Interface;

public interface IUserService
{
    public IEnumerable<EShopAppUser> GetAllUsers();

    public EShopAppUser GetUserById(string id);
}
