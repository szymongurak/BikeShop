using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BikeShop_DAL.Models;

namespace BikeShop_Services.DetailsOfProduct
{
    public class DetailsMappingProfile : Profile
    {
        public DetailsMappingProfile()
        {
            CreateMap<Product, ProductDetailsViewModel>();
        }
    }
}
