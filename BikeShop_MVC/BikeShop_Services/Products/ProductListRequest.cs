using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop_Services.Products
{
    public class ProductListRequest
    {
        public int? CatgoryId { get; set; }

        public string SearchedProducts { get; set; }

        public int? MinPrice { get; set; }

        public int? MaxPrice { get; set; }

        public int Page { get; set; }
    }
}
