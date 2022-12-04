using BookStore.Domain.Entity;
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
            var deleted = shoppingCart.Books.Where(z => z.Id.Equals(productId)).First();
            shoppingCart.Books.Remove(deleted);
            this._shoppingCartRepository.Update(shoppingCart);
            return true;
        }

        public ShoppingCart GetShoppingCartInfo(string userId)
        {
            var user = this._userRepository.Get(userId);
            return user.Cart;
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
                Id = Guid.NewGuid(),
                User = loggedInUser,
                UserId = userId,
                Books = new List<Book>()
            };

            foreach (var book in userCart.Books)
            {
                order.Books.Add(book);
            }
            this._orderRepository.Insert(order);
            loggedInUser.Cart.Books.Clear();
            this._userRepository.Update(loggedInUser);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Your order is completed. The order conatins: ");

            var booksCounts = order.Books.GroupBy(x => x.Id).Select(x => new { BookId = x.Key, Count = x.Count() });
            for (int i = 0; i < booksCounts.Count(); i++)
            {
                var element = booksCounts.ElementAt(i);
                var bookId = element.BookId;
                var book = order.Books.Where(x => x.Id.Equals(bookId)).First();
                sb.AppendLine($"{i}. {element.Count} x {book.BookName} - {book.Price} $");
            }

            var total = order.Books.Aggregate(0.0, (acc, book) => acc + (book.Price));
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
