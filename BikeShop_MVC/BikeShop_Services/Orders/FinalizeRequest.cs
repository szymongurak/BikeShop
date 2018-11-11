using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop_Services.Orders
{
    public class FinalizeRequest
    {
        public UserViewModel UserData { get; set; }

        public int OrderId { get; set; }

        public int CostOfShipment { get; set; }

        public decimal SummaryCost { get; set; }

        public string TypeOfShipment { get; set; }
    }
}
