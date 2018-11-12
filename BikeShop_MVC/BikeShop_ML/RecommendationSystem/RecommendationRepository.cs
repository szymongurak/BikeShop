using System.Collections.Generic;
using BikeShop_DAL.Models;
using BikeShop_DAL.Repositories;
using BikeShop_DAL.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BikeShop_ML.RecommendationSystem
{
    public class RecommendationRepository : IRecommendationRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public RecommendationRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public List<Rating> GetListOfRating(string userId)
        {
            return _applicationDbContext.Ratings
                .Where(u => u.UserId == userId)
                .Include(p => p.Product.Category)
                .ToList();
        }

        public List<Product> GetListOfProduct()
        {
            return _applicationDbContext.Products
                .Include(c => c.Category)
                .ToList();
        }

        public List<Product> GetRecommendedProducts(string userId)
        {
            return _applicationDbContext.Recommendations
                .Where(u => u.UserId == userId)
                .Include(p => p.Product)
                .Select(p => p.Product)
                .ToList();
        }

        public void AddRecommendation(int productId, string userId)
        {
            _applicationDbContext.Recommendations.Add(
                new Recommendation
                {
                    ProductId = productId,
                    UserId = userId
                });
        }

        public void RemoveRecommendation(string userId)
        {
            _applicationDbContext.Database.ExecuteSqlCommand($"DELETE FROM Recommendations WHERE UserId = {userId}");
        }

        public void Submit()
        {
            _applicationDbContext.SaveChanges();
        }

        public List<Rating> GetFullListOfRating()
        {
            return _applicationDbContext.Ratings
                .Include(p => p.Product)
                .Include(p => p.Product.Category)
                .Include(u => u.User)
                .ToList();
        }
    }
}
