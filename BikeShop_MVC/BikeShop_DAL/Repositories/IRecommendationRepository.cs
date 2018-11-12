using BikeShop_DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop_DAL.Repositories
{
    public interface IRecommendationRepository
    {
        List<Rating> GetListOfRating(string userId);

        List<Rating> GetFullListOfRating();

        List<Product> GetListOfProduct();

        List<Product> GetRecommendedProducts(string userId);

        void AddRecommendation(int productId, string userId);

        void RemoveRecommendation(string userId);

        void Submit();
    }
}
