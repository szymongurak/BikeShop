using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop_Services.HomePage
{
    public class HomePageResponse
    {
        public List<HomePageViewModel> LastAddedProducts { get; set; }

        public List<HomePageViewModel> RecommendedProducts { get; set; }
    }
}
