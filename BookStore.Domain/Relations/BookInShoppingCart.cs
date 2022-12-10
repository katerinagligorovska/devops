using BookStore.Domain.Entity;

namespace BookStore.Domain.Relations
{

    public class BookInShoppingCart
    {
        public Guid BookId { get; set; }
        public virtual Book CurrentBook { get; set; }
        public Guid ShoppingCartId { get; set; }
        public virtual ShoppingCart Cart { get; set; }

        public int Quantity { get; set; }
    }
}
