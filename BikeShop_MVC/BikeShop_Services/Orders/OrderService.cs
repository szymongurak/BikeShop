using System;
using System.Collections.Generic;
using BikeShop_DAL.Repositories;
using System.Linq;
using AutoMapper;
using BikeShop_DAL.Models.Enums;
using BikeShop_Services.Infrastructure;
using Microsoft.Extensions.Configuration;
using BikeShop_Services.Paging;
using BikeShop_Services.Orders.HistoryOfOrders;

namespace BikeShop_Services.Orders
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;
        private readonly IPagingService _pagingService;

        public OrderService(IOrderRepository orderRepository, IUserRepository userRepository, IConfiguration configuration, IPagingService pagingService)
        {
            _orderRepository = orderRepository;
            _userRepository = userRepository;
            _configuration = configuration;
            _pagingService = pagingService;
        }

        public OrderResponse GetOrderDetails(string userId)
        {
            var order = _orderRepository.GetOrdersByUser(userId)
                .Where(o => o.StatusOfOrder == OrderStatus.InProgress || o.StatusOfOrder == OrderStatus.Cart)
                .SingleOrDefault();
            if(order == null)
            {
                throw new InvalidOperationException("Order with status Cart or InProgress not exist.");                    
            }
            if (order.StatusOfOrder == OrderStatus.Cart)
            {
                order.StatusOfOrder = OrderStatus.InProgress;
                _orderRepository.Submit();
            }
            var listOfOrderPositions = _orderRepository.GetOrderById(order.OrderId).OrderPositions
                .ToList();
            var summaryCost = listOfOrderPositions
                .Sum(o => o.TotalPrice);
            var user = _userRepository.GetUserById(order.UserId);

            return new OrderResponse
            {
                ListOdOrderPositions = Mapper.Map<List<OrderPositionsViewModel>>(listOfOrderPositions),
                UserData = Mapper.Map<UserViewModel>(user),
                SummaryCost = summaryCost,
                ListOfShipmentTypes = GetListOfShipmentTypes(),
                TotalCost = summaryCost + GetListOfShipmentTypes()[0].CostOfShipment,
                OrderId = order.OrderId
            };
        }

        public void ReturnToCartStatus(int orderId)
        {
            var order = _orderRepository.GetOrderById(orderId);
            order.StatusOfOrder = OrderStatus.Cart;
            _orderRepository.Submit();
        }

        public OperationResult<OrderResponse> UpdateTotalCost(int costOfShipment, decimal summaryCost)
        {
            var totalCost = summaryCost + costOfShipment;

            return OperationResult<OrderResponse>.Success(new OrderResponse
            {
                TotalCost = totalCost
            });
        }

        public void FinalizeOrder(FinalizeRequest finalizeRequest)
        {
            var uvm = finalizeRequest.UserData;

            var order = _orderRepository.GetOrderById(finalizeRequest.OrderId);

            order.Address = uvm.Address;
            order.City = uvm.City;
            order.Country = uvm.Country;
            order.Email = uvm.Email;
            order.FirstName = uvm.FirstName;
            order.LastName = uvm.LastName;
            order.PhoneNumber = uvm.PhoneNumber;
            order.TotalCost = finalizeRequest.SummaryCost + finalizeRequest.CostOfShipment;
            order.CostOfShipment = finalizeRequest.CostOfShipment;
            order.TypeOfShipment = finalizeRequest.TypeOfShipment;
            order.OrderDate = DateTime.Now;
            order.StatusOfOrder = OrderStatus.Placed;
            _orderRepository.Submit();
        }

        private List<ShipmentTypeViewModel> GetListOfShipmentTypes()
        {
            List<ShipmentTypeViewModel> list = new List<ShipmentTypeViewModel>();
            foreach(IConfigurationSection item in _configuration.GetSection("ShipmentMethod").GetChildren())
            {
                var price = 0;
                Int32.TryParse(item.GetValue<string>("Price"), out price);
                var name = item.GetValue<string>("Name");
                list.Add(new ShipmentTypeViewModel { TypeOfShipment = name, CostOfShipment = price });
            }
            return list;
        }

        public HistoryOfOrdersResponse GetHistoryOfOrders(string userId, int page)
        {
            var listOfOrders = _orderRepository.GetOrdersByUser(userId)
                .Where(o => o.StatusOfOrder == OrderStatus.Placed)
                .OrderByDescending(d => d.OrderDate)
                .ToList();

            var pagingResult = _pagingService.GetOnePageOfProducts(listOfOrders, page);

            return new HistoryOfOrdersResponse
            {
                ListOfOrders = Mapper.Map<List<OrderViewModel>>(pagingResult.ListOfItems),
                CurrentPage = pagingResult.CurrentPage,
                PageCount = pagingResult.PageCount
            };
        }

        public OrderDetailsResponse GetDetailsOfOrderFromHistory(int orderId)
        {
            var order = _orderRepository.GetOrderById(orderId);

            return new OrderDetailsResponse
            {
                UserData = Mapper.Map<UserViewModel>(order),
                ListOdOrderPositions = Mapper.Map<List<OrderPositionsViewModel>>(order.OrderPositions.ToList()),
                ShipmentData = Mapper.Map<ShipmentTypeViewModel>(order)
            };
        }
    }
}
