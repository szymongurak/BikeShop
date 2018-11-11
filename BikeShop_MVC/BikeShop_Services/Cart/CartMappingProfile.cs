using AutoMapper;
using BikeShop_DAL.Models;

namespace BikeShop_Services.Cart
{
    public class CartMappingProfile : Profile
    {
        public CartMappingProfile()
        {
            CreateMap<OrderPosition, CartViewModel>();
        }
    }
}
