using BookStore.Domain.Entity;

namespace BookStore.Domain.Relations
{
    public class BookInOrder : BaseEntity
    {
        public Guid BookId { get; set; }
        public virtual Book Book { get; set; }
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int Quantity { get; set; }
    }
}
