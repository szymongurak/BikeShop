using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BikeShop_Services.Orders.HistoryOfOrders
{
    public class HistoryOfOrdersResponse
    {
        public List<OrderViewModel> ListOfOrders { get; set; }

        public int PageCount { get; set; }

        public int CurrentPage { get; set; }

        public string GetCurrentUrl(IUrlHelper urlHelper)
        {
            return urlHelper.Action("History", "Order");
        }
    }
}
