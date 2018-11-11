using System;
using System.Collections.Generic;
using System.Text;
using BikeShop_DAL.Models;

namespace BikeShop_DAL.Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetAllOrders();

        Order GetOrderById(int orderId);

        List<Order> GetOrdersByUser(string userId);

        OrderPosition GetOrderPositionById(int orderPositionId);

        void AddOrder(Order order);

        void AddOrderPosition(OrderPosition orderPosition);

        void RemoveOrder(int orderId);

        void RemoveOrderPosition(int orderId);

        void Submit();
    }
}
