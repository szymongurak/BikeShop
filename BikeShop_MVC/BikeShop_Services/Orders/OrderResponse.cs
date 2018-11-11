using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop_Services.Orders
{
    public class OrderResponse
    {
        public List<OrderPositionsViewModel> ListOdOrderPositions { get; set; }

        public List<ShipmentTypeViewModel> ListOfShipmentTypes { get; set; }

        public UserViewModel UserData { get; set; }

        public decimal SummaryCost { get; set; }

        public decimal TotalCost { get; set; }

        public int OrderId { get; set; }
    }
}
