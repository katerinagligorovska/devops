using BookStore.Domain.Identity;
using BookStore.Repository.Interface;
using BookStore.Service.Interface;

namespace BookStore.Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<EShopAppUser> GetAllUsers()
        {
            return this._userRepository.GetAll();
        }

        public EShopAppUser GetUserById(string id)
        {
            return this._userRepository.Get(id);
        }
    }
}
