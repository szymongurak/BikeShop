using BikeShop_DAL.Data;
using BikeShop_DAL.Models;
using System.Linq;
using System.Collections.Generic;

namespace BikeShop_DAL.Repositories
{
    public class RatingRepository : IRatingRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public RatingRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Rating GetRating(string userId, int productId)
        {
            return _applicationDbContext.Ratings
                .Where(r => r.UserId == userId && r.ProductId == productId)
                .SingleOrDefault();
        }

        public List<Rating> GetRatingsByProductId(int productId)
        {
            return _applicationDbContext.Ratings
                .Where(p => p.ProductId == productId)
                .ToList();
        }

        public void AddRating(Rating rating)
        {
            _applicationDbContext.Ratings.Add(rating);
            _applicationDbContext.SaveChanges();
        }

        public void Submit()
        {
            _applicationDbContext.SaveChanges();
        }
    }
}
