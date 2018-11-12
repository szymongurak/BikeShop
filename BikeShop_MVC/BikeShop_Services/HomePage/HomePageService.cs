using System;
using BikeShop_DAL.Repositories;
using System.Linq;
using AutoMapper;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using BikeShop_ML.RecommendationSystem;
using BikeShop_DAL.Models;
using System.IO;
using Microsoft.ML.Legacy;
using Hangfire;

namespace BikeShop_Services.HomePage
{
    public class HomePageService : IHomePageService
    {
        private readonly IProductRepository _productRepository;
        private readonly IConfiguration _configuration;
        private readonly IRecommendationService _recommendationService;
        private readonly IRatingRepository _ratingRepository;
        private readonly IUserRepository _userRepository;

        public HomePageService(IProductRepository productRepository, IConfiguration configuration, IRecommendationService recommendationService, IRatingRepository ratingRepository, IUserRepository userRepository)
        {
            _productRepository = productRepository;
            _configuration = configuration;
            _recommendationService = recommendationService;
            _ratingRepository = ratingRepository;
            _userRepository = userRepository;
        }

        public HomePageResponse GetProductsToHomePage(string userId)
        {
            var numberOfLastProducts = 0;
            Int32.TryParse(_configuration.GetSection("NumberOfLastProduct").Value, out numberOfLastProducts);
            var lastAddedProducts = _productRepository.GetAllProducts()
                .OrderByDescending(p => p.Id).Take(numberOfLastProducts);

            List<Product> recommendedProducts = new List<Product>();

            if ((userId != null && _ratingRepository.GetRatingsByUserId(userId).Count >= 20) || (userId != null && _recommendationService.UserHasAdditionalData(userId) == true))
            {
                recommendedProducts = _recommendationService.GetRecommendedProducts(userId);
            }
            else
            {
                recommendedProducts = _productRepository.GetAllProducts()
                .Where(p => p.Recommended)
                .ToList();
            }
            
            return new HomePageResponse
            {
                LastAddedProducts = Mapper.Map<List<HomePageViewModel>>(lastAddedProducts),
                RecommendedProducts = Mapper.Map<List<HomePageViewModel>>(recommendedProducts)
            };
        }
    }
}
