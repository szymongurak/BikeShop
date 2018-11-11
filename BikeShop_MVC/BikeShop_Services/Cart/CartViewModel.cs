using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop_Services.Cart
{
    public class CartViewModel
    {
        public int OrderPositionId { get; set; }

        public int Quantity { get; set; }

        public string NameOfProduct { get; set; }

        public decimal Price { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
