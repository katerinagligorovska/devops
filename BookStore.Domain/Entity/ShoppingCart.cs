using BookStore.Domain.Identity;
using BookStore.Domain.Relations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Entity
{
    public class ShoppingCart : BaseEntity
    {
        public string OwnerId { get; set; }
        public virtual EShopAppUser Owner { get; set; }
        public virtual ICollection<BookInShoppingCart> BookInShoppingCarts { get; set; }
    }
}
