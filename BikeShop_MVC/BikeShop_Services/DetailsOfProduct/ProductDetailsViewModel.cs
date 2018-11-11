using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop_Services.DetailsOfProduct
{
    public class ProductDetailsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public string Picture { get; set; }
    }
}
