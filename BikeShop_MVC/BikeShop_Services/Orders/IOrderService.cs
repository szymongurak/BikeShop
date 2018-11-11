using System;
using System.Collections.Generic;
using System.Text;
using BikeShop_Services.Infrastructure;
using BikeShop_Services.Orders.HistoryOfOrders;

namespace BikeShop_Services.Orders
{
     public interface IOrderService
    {
        OrderResponse GetOrderDetails(string userId);

        void ReturnToCartStatus(int orderId);

        OperationResult<OrderResponse> UpdateTotalCost(int costOfShipment, decimal summaryCost);

        void FinalizeOrder(FinalizeRequest finalizeRequest);

        HistoryOfOrdersResponse GetHistoryOfOrders(string userId, int page);

        OrderDetailsResponse GetDetailsOfOrderFromHistory(int orderId);
    }
}
