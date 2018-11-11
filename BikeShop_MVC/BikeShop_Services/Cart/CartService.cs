using System.Linq;
using BikeShop_DAL.Models;
using BikeShop_DAL.Repositories;
using BikeShop_DAL.Models.Enums;
using BikeShop_Services.Infrastructure;
using AutoMapper;
using System.Collections.Generic;

namespace BikeShop_Services.Cart
{
    public class CartService : ICartService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;

        public CartService(IOrderRepository orderRepository, IProductRepository productRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
        }

        public OperationResult AddProductToCart(string userId, int productId, int selectedQuantity)
        {
            Product productToAdd = _productRepository.GetProductById(productId);

            if(selectedQuantity > productToAdd.Quantity)
            {
                return OperationResult.Error("Error! Selected quantity is less than state of the warehouse.");
            }

            if (selectedQuantity <= 0)
            {
                return OperationResult.Error("Error! Selected quantity is too little.");
            }

            var order = GetCartOrRestoreToCart(userId);

            if(order == null)
            {
                order = CreateNewOrder(userId);
            }

            var listOfOrderPositions = _orderRepository.GetOrderById(order.OrderId).OrderPositions;

            var existedProductInOrder = listOfOrderPositions
                .Where(o => o.ProductId == productId)
                .SingleOrDefault();

            if (existedProductInOrder == null)
            {
                OrderPosition orderPosition = new OrderPosition
                {
                    NameOfProduct = productToAdd.Name,
                    Price = productToAdd.Price,
                    Quantity = selectedQuantity,
                    TotalPrice = selectedQuantity * productToAdd.Price,
                    ProductId = productId,
                    OrderId = order.OrderId
                };
                _orderRepository.AddOrderPosition(orderPosition);
            }
            else
            {
                existedProductInOrder.Quantity = existedProductInOrder.Quantity + selectedQuantity;
                existedProductInOrder.TotalPrice = existedProductInOrder.Quantity * existedProductInOrder.Price;
            }

            var product = _productRepository.GetProductById(productId);
            product.Quantity = product.Quantity - selectedQuantity;
            _productRepository.UpdateProduct(product);
            _orderRepository.Submit();

            return OperationResult.Success();
        }

        public int GetCountOfOrderPositionsInCart(string userId) => GetCart(userId)?.OrderPositions.Count ?? 0;

        public OperationResult<CartResponse> GetListOfProductsInCart(string userId)
        {
            var orderId = GetCartOrRestoreToCart(userId)?.OrderId ?? CreateNewOrder(userId).OrderId;

            var listOfOrderPositions = _orderRepository.GetOrderById(orderId).OrderPositions
                .ToList();

            var summaryCost = listOfOrderPositions
                .Sum(s => s.TotalPrice);

            var cartResponse = new CartResponse
            {
                ListOfProductsInCart = Mapper.Map<List<CartViewModel>>(listOfOrderPositions),
                SummaryCost = summaryCost,
                OrderId = orderId
            };

            return OperationResult<CartResponse>.Success(cartResponse);
        }

        public OperationResult<CartResponse> UpadteSelectedQuantity(int orderPositionId, int selectedQuantity)
        {
            if(selectedQuantity <= 0)
            {
                return OperationResult<CartResponse>.Error("Error! The selected value is too small");
            }

            var orderPosition = _orderRepository.GetOrderPositionById(orderPositionId);
            var product = _productRepository.GetProductById(orderPosition.ProductId);
            var differece = orderPosition.Quantity - selectedQuantity;

            if (product.Quantity + orderPosition.Quantity < selectedQuantity)
            {
                return OperationResult<CartResponse>.Error("Error! The selected value is too big");
            }

            product.Quantity += differece;
            orderPosition.Quantity = selectedQuantity;
            orderPosition.TotalPrice = orderPosition.Quantity * orderPosition.Price;
            _productRepository.UpdateProduct(product);
            _orderRepository.Submit();
            var orderId = orderPosition.OrderId;
            var summaryCost = _orderRepository.GetOrderById(orderId).OrderPositions 
                .ToList().Sum(s => s.TotalPrice);

            return OperationResult<CartResponse>.Success(new CartResponse
            {
                CountOfProducts = selectedQuantity,
                TotalPrice = orderPosition.TotalPrice,
                SummaryCost = summaryCost
            });
        }

        public OperationResult RemoveProductFromCart(int orderPositionId)
        {
            var orderPosition = _orderRepository.GetOrderPositionById(orderPositionId);
            var product = _productRepository.GetProductById(orderPosition.ProductId);
            product.Quantity += orderPosition.Quantity;
            _productRepository.UpdateProduct(product);
            _orderRepository.RemoveOrderPosition(orderPositionId);
            _orderRepository.Submit();

            return OperationResult.Success();
        }

        private Order GetCart(string userId)
        {
            return _orderRepository.GetOrdersByUser(userId)
                .Where(s => s.StatusOfOrder == OrderStatus.Cart)
                .FirstOrDefault();
        }

        private Order GetCartOrRestoreToCart(string userId)
        {
            var order = _orderRepository.GetOrdersByUser(userId)
                .Where(o => o.StatusOfOrder == OrderStatus.InProgress || o.StatusOfOrder == OrderStatus.Cart)
                .SingleOrDefault();
            if (order!=null && order.StatusOfOrder == OrderStatus.InProgress)
            {
                order.StatusOfOrder = OrderStatus.Cart;
                _orderRepository.Submit();
            }
            return order;
        }

        private Order CreateNewOrder(string userId)
        {
            var order = new Order
            {
                UserId = userId,
                StatusOfOrder = OrderStatus.Cart
            };
            _orderRepository.AddOrder(order);
            _orderRepository.Submit();
            return order;
        }

        public int? GetIdOfOrderWithInProgressStatus(string userId)
        {
            var order = _orderRepository.GetOrdersByUser(userId)
                .Where(s => s.StatusOfOrder == OrderStatus.InProgress)
                .SingleOrDefault();

            return order?.OrderId;
        }
    }
}