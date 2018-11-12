using Microsoft.AspNetCore.Mvc;
using BikeShop_Services.HomePage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using BikeShop_DAL.Models;

namespace BikeShop_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomePageService _homePageService;
        private readonly UserManager<User> _userManager;

        public HomeController(IHomePageService homePageService, UserManager<User> userManager)
        {
            _homePageService = homePageService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View("Index", _homePageService.GetProductsToHomePage(_userManager.GetUserId(this.User)));
        }
    }
}
