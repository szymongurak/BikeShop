using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BikeShop_DAL.Models;

namespace BikeShop_Services.HomePage
{
    public class HomePageMappingProfile : Profile
    {
        public HomePageMappingProfile()
        {
            CreateMap<Product, HomePageViewModel>();
        }
    }
}
