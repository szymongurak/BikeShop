using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BikeShop_DAL.Models;

namespace BikeShop_Services.Products
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductViewModel>();
            CreateMap<Category, CategoryViewModel>();
        }
    }
}
