using BookStore.Domain.DTO;
using BookStore.Domain.Entity;
using BookStore.Domain.Relations;
using BookStore.Repository.Interface;
using BookStore.Service.Interface;

namespace BookStore.Service.Implementation
{
    public class BookService : IBookService
    {
        private readonly IRepository<Book> _bookRepository;
        private readonly IUserRepository _userRepository;
        private readonly IRepository<ShoppingCart> _shoppingCartRepository;


        public BookService(IRepository<Book> bookRepository, IUserRepository userRepository, IRepository<ShoppingCart> shoppingCartRepository)
        {
            _bookRepository = bookRepository;
            _userRepository = userRepository;
            _shoppingCartRepository = shoppingCartRepository;
        }


        public bool AddToShoppingCart(AddToShoppingCartDto item, string userID)
        {
            var user = this._userRepository.Get(userID);
            var cart = user.Cart;
            cart.BookInShoppingCarts ??= new List<BookInShoppingCart>();
            var persisted = cart.BookInShoppingCarts.Where(b => b.CurrentBook.Id == item.SelectedBookId).FirstOrDefault();
            var exists = persisted != null;
            persisted ??= new BookInShoppingCart() { BookId = item.SelectedBookId, ShoppingCartId = cart.Id, Quantity = 0 };
            if (!exists)
            {
                cart.BookInShoppingCarts.Add(persisted);
            }
            persisted.Quantity += item.Quantity;

            _shoppingCartRepository.Update(cart);
            return true;
        }

        public void CreateNewBook(Book p)
        {
            this._bookRepository.Insert(p);
        }

        public void DeleteBook(Guid id)
        {
            var book = this.GetDetailsForBook(id);
            this._bookRepository.Delete(book);
        }
        public List<Book> GetAllBooksGenre(string genre)
        {
            return this._bookRepository.GetAll().Where(book => book.Genre.Equals(genre)).ToList();
        }

        public List<Book> GetAllBooksByTitle(string title)
        {
            return this._bookRepository.GetAll().Where(book => book.BookName.ToLower().Contains(title.ToLower())).ToList();
        }


        public List<Book> GetAllBooks()
        {
            return this._bookRepository.GetAll().ToList();
        }

        public Book GetDetailsForBook(Guid id)
        {
            return this._bookRepository.Get(id);
        }

        public AddToShoppingCartDto GetShoppingCartInfo(Guid id)
        {
            var book = this.GetDetailsForBook(id);
            var model = new AddToShoppingCartDto
            {
                SelectedBook = book,
                SelectedBookId = book.Id,
                Quantity = 1
            };

            return model;
        }

        public void UpdeteExistingBook(Book p)
        {
            this._bookRepository.Update(p);
        }
    }
}
