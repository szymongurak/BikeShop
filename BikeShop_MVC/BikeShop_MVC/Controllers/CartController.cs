using Microsoft.AspNetCore.Mvc;
using BikeShop_Services.Cart;
using Microsoft.AspNetCore.Identity;
using BikeShop_DAL.Models;
using BikeShop_Services.Infrastructure;
using Microsoft.AspNetCore.Authorization;

namespace BikeShop_MVC.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly UserManager<User> _userManager;

        public CartController(ICartService cartService, UserManager<User> userManager)
        {
            _cartService = cartService;
            _userManager = userManager;
        }

        [Route("~/[controller]")]
        public IActionResult Index(int productId)
        {
            var userId = _userManager.GetUserId(this.User);
            var orderWithInProgressStatus = _cartService.GetIdOfOrderWithInProgressStatus(userId);
            if (orderWithInProgressStatus.HasValue)
            {
                return RedirectToAction("Index", "Order", new { orderId = orderWithInProgressStatus });
            }
            var result = _cartService.GetListOfProductsInCart(userId);
            return View("Index", result);
        }

        [HttpPost]
        public OperationResult AddProductToCart(int productId, int selectedQuantity)
        {
            var userId = _userManager.GetUserId(this.User);
            if (userId != null)
            {
                var result = _cartService.AddProductToCart(userId, productId, selectedQuantity);
                return result;
            }
            return OperationResult.Error("User error!");
        }

        [Route("{orderPositionId}")]
        public IActionResult RemoveProductFromCart(int orderPositionId)
        {
            _cartService.RemoveProductFromCart(orderPositionId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public OperationResult<CartResponse> UpdateQuantity(int orderPositionId, int newQuantity)
        {
            var result = _cartService.UpadteSelectedQuantity(orderPositionId, newQuantity);
            return result;
        }
    }
}
