using System.Collections.Generic;

namespace BikeShop_Services.Orders.HistoryOfOrders
{
    public class OrderDetailsResponse
    {
        public UserViewModel UserData { get; set; }

        public List<OrderPositionsViewModel> ListOdOrderPositions { get; set; }

        public ShipmentTypeViewModel ShipmentData { get; set; }
    }
}
