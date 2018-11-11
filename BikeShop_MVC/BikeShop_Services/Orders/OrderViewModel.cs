using System;

namespace BikeShop_Services.Orders
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalCost { get; set; }
    }
}
