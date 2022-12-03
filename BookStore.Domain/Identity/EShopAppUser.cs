using BookStore.Domain.Entity;
using Microsoft.AspNetCore.Identity;

namespace BookStore.Domain.Identity
{
    public class EShopAppUser : IdentityUser

    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ShoppingCart UserCart { get; set; }
    }
}
