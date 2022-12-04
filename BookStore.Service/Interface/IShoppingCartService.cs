using BookStore.Domain.Entity;

namespace BookStore.Service.Interface
{
    public interface IShoppingCartService
    {
        ShoppingCart GetShoppingCartInfo(string userId);
        bool DeleteBookFromShoppingCart(string userId, Guid bookId);
        bool CanCreateOrder(string userId);
    }
}
