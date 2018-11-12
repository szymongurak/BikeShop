using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop_Services.HomePage
{
    public interface IHomePageService
    {
        HomePageResponse GetProductsToHomePage(string userId);
    }
}
