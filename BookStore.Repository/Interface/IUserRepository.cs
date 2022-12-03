using BookStore.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
