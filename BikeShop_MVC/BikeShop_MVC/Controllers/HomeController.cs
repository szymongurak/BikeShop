using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BikeShop_Services.HomePage;

namespace BikeShop_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomePageService _homePageService;

        public HomeController(IHomePageService homePageService)
        {
            _homePageService = homePageService;
        }

        public IActionResult Index()
        {
            return View("Index", _homePageService.GetProductsToHomePage());
        }
    }
}
