using BookStore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Relations
{
    public class BookInShoppingCart :BaseEntity
    {
        public Guid BookId { get; set; }
        public virtual Book CurrnetBook { get; set; }

        public Guid ShoppingCartId { get; set; }
        public virtual ShoppingCart UserCart { get; set; }

        public int Quantity { get; set; }
    }
}
