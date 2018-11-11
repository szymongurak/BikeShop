using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore;
using BikeShop_Services.Orders;
using BikeShop_Services.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using BikeShop_DAL.Models;
using Microsoft.AspNetCore.Http;

namespace BikeShop_MVC.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly UserManager<User> _userManager;

        public OrderController(IOrderService orderService, UserManager<User> userManager)
        {
            _orderService = orderService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            try
            {
                var result = _orderService.GetOrderDetails(_userManager.GetUserId(this.User));
                return View("Index", result);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
            
        }

        [Route("[action]")]
        public IActionResult ReturnToCart(int orderId)
        {
            _orderService.ReturnToCartStatus(orderId);
            return RedirectToAction("Index", "Cart");
        }

        [HttpPost]
        [Route("[action]")]
        public OperationResult<OrderResponse> ChangeTypeOfShipment(int costOfShipment, decimal summaryCost)
        {
            return _orderService.UpdateTotalCost(costOfShipment, summaryCost);
        }

        [Route("[action]")]
        public IActionResult FinalizeOrder(FinalizeRequest finalizeRequest)
        {
            if (ModelState.IsValid)
            {
                _orderService.FinalizeOrder(finalizeRequest);
                return RedirectToAction("Index", "Home");
            }
            TempData["errorMessage"] = "Error! User informations are invalid.";
            return RedirectToAction("Index");
        }

        [Route("[action]")]
        public IActionResult History(int pageNo = 1)
        {
            return View("History", _orderService.GetHistoryOfOrders(_userManager.GetUserId(this.User), pageNo));
        }

        [Route("[action]")]
        public IActionResult OrderDetails(int orderId)
        {
            var result = _orderService.GetDetailsOfOrderFromHistory(orderId);
            return PartialView("_OrderDetailsPartial", result);
        }

    }
}
