using BookStore.Domain.Identity;

namespace BookStore.Domain.Entity
{
    public class Order : BaseEntity
    {
        public string UserId { get; set; }
        public EShopAppUser User { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
