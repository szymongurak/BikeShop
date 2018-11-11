using AutoMapper;
using BikeShop_DAL.Models;

namespace BikeShop_Services.Orders
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            Mapper.Reset();

            CreateMap<OrderPosition, OrderPositionsViewModel>();

            CreateMap<User, UserViewModel>();

            CreateMap<Order, OrderViewModel>();

            CreateMap<Order, UserViewModel>();

            CreateMap<Order, ShipmentTypeViewModel>();
        }
    }
}
