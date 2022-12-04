using BookStore.Domain.Identity;

namespace BookStore.Domain.Entity
{
    public class ShoppingCart : BaseEntity
    {
        public string OwnerId { get; set; }
        public virtual EShopAppUser Owner { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public ShoppingCart()
        {
            this.Books = new List<Book>();
        }
    }
}
