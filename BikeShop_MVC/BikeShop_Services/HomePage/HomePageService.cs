using System;
using BikeShop_DAL.Repositories;
using System.Linq;
using AutoMapper;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace BikeShop_Services.HomePage
{
    public class HomePageService : IHomePageService
    {
        private readonly IProductRepository _productRepository;
        private readonly IConfiguration _configuration;

        public HomePageService(IProductRepository productRepository, IConfiguration configuration)
        {
            _productRepository = productRepository;
            _configuration = configuration;
        }

        public HomePageResponse GetProductsToHomePage()
        {
            var numberOfLastProducts = 0;
            Int32.TryParse(_configuration.GetSection("NumberOfLastProduct").Value, out numberOfLastProducts);
            var lastAddedProducts = _productRepository.GetAllProducts()
                .OrderByDescending(p => p.Id).Take(numberOfLastProducts);

            var recommendedProduct = _productRepository.GetAllProducts()
                .Where(p => p.Recommended)
                .ToList();

            return new HomePageResponse
            {
                LastAddedProducts = Mapper.Map<List<HomePageViewModel>>(lastAddedProducts),
                RecommendedProducts = Mapper.Map<List<HomePageViewModel>>(recommendedProduct)
            };
        }
    }
}
