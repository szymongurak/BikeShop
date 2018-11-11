using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop_MVC.Components
{
    public class PagingViewComponentResult
    {
        public string Url { get; set; }

        public int PageCount { get; set; }

        public int CurrentPage { get; set; }
    }
}
