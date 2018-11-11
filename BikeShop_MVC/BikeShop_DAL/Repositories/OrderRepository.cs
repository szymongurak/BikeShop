using System;
using System.Collections.Generic;
using System.Text;
using BikeShop_DAL.Data;
using BikeShop_DAL.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BikeShop_DAL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public OrderRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public List<Order> GetAllOrders()
        {
            return _applicationDbContext.Orders.ToList();
        }

        public Order GetOrderById(int orderId)
        {
            return _applicationDbContext.Orders
                .Where(o => o.OrderId == orderId)
                .Include(o => o.OrderPositions)
                .SingleOrDefault();
        }

        public OrderPosition GetOrderPositionById(int orderPositionId)
        {
            return _applicationDbContext.OrderPositions
                .Find(orderPositionId);
        }

        public void AddOrder(Order order)
        {
            _applicationDbContext.Add(order);
        }

        public void AddOrderPosition(OrderPosition orderPosition)
        {
            _applicationDbContext.Add(orderPosition);
        }

        public void RemoveOrder(int orderId)
        {
            var foundOrder = GetOrderById(orderId);
            _applicationDbContext.Remove(foundOrder);
        }

        public void RemoveOrderPosition(int orderPositionId)
        {
            var foundOrderPosition = GetOrderPositionById(orderPositionId);
            _applicationDbContext.Remove(foundOrderPosition);
        }

        public List<Order> GetOrdersByUser(string userId)
        {
            return _applicationDbContext.Orders
                .Where(o => o.UserId == userId)
                .Include(o => o.OrderPositions)
                .ToList();
        }

        public void Submit()
        {
            _applicationDbContext.SaveChanges();
        }
    }
}
