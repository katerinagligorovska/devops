using BookStore.Domain.Identity;
using BookStore.Repository.Interface;
using BookStore.Service.Interface;
using Microsoft.Extensions.Logging;

namespace BookStore.Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger<UserService> _logger;
        public UserService(ILogger<UserService> logger, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _logger = logger;
        }


        public List<EShopAppUser> GetAllUsers()
        {
            _logger.LogInformation("GetAllUsers was called!");
            return this._userRepository.GetAll().ToList();
        }
    }
}
