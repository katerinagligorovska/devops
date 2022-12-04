using BookStore.Domain.Relations;

namespace BookStore.Domain.DTO
{
    public class ShoppingCartDto
    {
        public List<BookInShoppingCart> Books { get; set; }

        public double TotalPrice { get; set; }
    }
}
