using BookStore.Domain.Entity;
using BookStore.Domain.Relations;
using BookStore.Repository.Interface;
using BookStore.Service.Interface;
using System.Text;

namespace BookStore.Service.Implementation
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IRepository<ShoppingCart> _shoppingCartRepository;
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<EmailMessage> _mailRepository;
        private readonly IUserRepository _userRepository;

        public ShoppingCartService(IRepository<ShoppingCart> shoppingCartRepository, IUserRepository userRepository, IRepository<EmailMessage> mailRepository, IRepository<Order> orderRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _userRepository = userRepository;
            _orderRepository = orderRepository;
            _mailRepository = mailRepository;
        }


        public bool DeleteBookFromShoppingCart(string userId, Guid productId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                return false;
            }

            var user = this._userRepository.Get(userId);
            var shoppingCart = user.Cart;
            var deleted = shoppingCart.BookInShoppingCarts.Where(z => z.CurrentBook.Id == productId).First();
            shoppingCart.BookInShoppingCarts.Remove(deleted);
            this._shoppingCartRepository.Update(shoppingCart);
            return true;
        }

        public ShoppingCart GetShoppingCartInfo(string userId)
        {
            var user = this._userRepository.Get(userId);
            var userCart = user.Cart;

            var books = userCart.BookInShoppingCarts.ToList();
            var result = new ShoppingCart
            {
                BookInShoppingCarts = books,
                OwnerId = user.Id,
                Owner = user
            };
            return result;

        }

        public bool CanCreateOrder(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                return false;
            }

            var loggedInUser = this._userRepository.Get(userId);
            var userCart = loggedInUser.Cart;
            var order = new Order
            {
                UserId = loggedInUser.Id,
                BooksInOrder = new List<BookInOrder>()
            };
            foreach (var book in userCart.BookInShoppingCarts)
            {
                var bookInOrder = new BookInOrder
                {
                    BookId = book.CurrentBook.Id,
                    Book = book.CurrentBook,
                    Quantity = book.Quantity,
                };
                order.BooksInOrder.Add(bookInOrder);
            }

            this._orderRepository.Insert(order);
            loggedInUser.Cart.BookInShoppingCarts.Clear();
            this._userRepository.Update(loggedInUser);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Your order is completed. The order conatins: ");

            var booksCounts = order.BooksInOrder.GroupBy(x => x.Id).Select(x => new { BookId = x.Key, Count = x.Count() });
            for (int i = 0; i < booksCounts.Count(); i++)
            {
                var element = booksCounts.ElementAt(i);
                var bookId = element.BookId;
                var bookInOrder = order.BooksInOrder.Where(x => x.Id.Equals(bookId)).First();
                sb.AppendLine($"{i}. {element.Count} x {bookInOrder.Book.Id} - {bookInOrder.Book.Price} $");
            }

            var total = order.BooksInOrder.Aggregate(0.0, (acc, book) => acc + (book.Book.Price));
            sb.AppendLine($"Total price for your order: {total}");

            var mail = new EmailMessage();
            mail.MailTo = loggedInUser.Email;
            mail.Subject = "Sucessfuly created order!";
            mail.Status = false;
            mail.Content = sb.ToString();

            this._mailRepository.Insert(mail);
            return true;
        }
    }
}
