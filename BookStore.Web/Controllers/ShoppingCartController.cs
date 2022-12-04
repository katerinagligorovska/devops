using BookStore.Domain.Entity;
using BookStore.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using System.Security.Claims;

namespace BookStore.Web.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly IShoppingCartService _shoppingCartService;

        public ShoppingCartController(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var shoppingCart = this._shoppingCartService.GetShoppingCartInfo(userId);
            shoppingCart.Books ??= new List<Book>();
            return View(shoppingCart);
        }

        public IActionResult DeleteFromShoppingCart(Guid id)
        {

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var result = this._shoppingCartService.DeleteBookFromShoppingCart(userId, id);

            if (result)
            {
                return RedirectToAction("Index", "ShoppingCard");
            }
            else
            {
                return RedirectToAction("Index", "ShoppingCard");
            }
        }

        public Boolean Order()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = this._shoppingCartService.CanCreateOrder(userId);
            return result;
        }

        public IActionResult PayOrder(string stripeEmail, string stripeToken)
        {
            var customerService = new CustomerService();
            var chargeService = new ChargeService();
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var order = this._shoppingCartService.GetShoppingCartInfo(userId);

            var customer = customerService.Create(new CustomerCreateOptions
            {
                Email = stripeEmail,
                Source = stripeToken
            });
            var total = order.Books.Sum(x => x.Price);
            var charge = chargeService.Create(new ChargeCreateOptions
            {
                Amount = total,
                Description = "EBook Application Payment",
                Currency = "usd",
                Customer = customer.Id
            });

            if (charge.Status == "succeeded")
            {
                var result = this.Order();

                if (result)
                {
                    return RedirectToAction("Index", "ShoppingCard");
                }
                else
                {
                    return RedirectToAction("Index", "ShoppingCard");
                }
            }

            return RedirectToAction("Index", "ShoppingCard");
        }
    }
}
