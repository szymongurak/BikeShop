using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop_Services.Cart
{
    public class CartResponse
    {
        public List<CartViewModel> ListOfProductsInCart { get; set; }

        public decimal SummaryCost { get; set; }

        public int CountOfProducts { get; set; }

        public decimal TotalPrice { get; set; }

        public int OrderId { get; set; }
    }
}
