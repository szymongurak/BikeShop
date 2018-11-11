using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeShop_Services.Cart;
using Microsoft.AspNetCore.Mvc;

namespace BikeShop_MVC.Components
{
    public class CartViewComponent : ViewComponent
    {
        private readonly ICartService _cartService;

        public CartViewComponent(ICartService cartService)
        {
            _cartService = cartService;
        }

        public IViewComponentResult Invoke(string userId)
        {
            var numberOfProducts = _cartService.GetCountOfOrderPositionsInCart(userId);
            return View(numberOfProducts);
        }
    }
}
