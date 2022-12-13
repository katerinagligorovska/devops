using BookStore.Domain.Identity;
using BookStore.Domain.Relations;

namespace BookStore.Domain.Entity
{
    public class Order : BaseEntity
    {
        public string UserId { get; set; }
        public EShopAppUser User { get; set; }
        public virtual ICollection<BookInOrder> BooksInOrder { get; set; }
    }
}
