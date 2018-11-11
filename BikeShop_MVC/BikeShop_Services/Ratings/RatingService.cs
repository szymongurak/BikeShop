using System;
using BikeShop_DAL.Models;
using BikeShop_DAL.Repositories;
using System.Linq;

namespace BikeShop_Services.Ratings
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _ratingRepository;

        public RatingService(IRatingRepository ratingRepository)
        {
            _ratingRepository = ratingRepository;
        }

        public RatingStats SaveRating(int ratingValue, string userId, int productId)
        {
            var rating = _ratingRepository.GetRating(userId, productId);

            if (rating == null)
            {
                rating = new Rating
                {
                    ProductId = productId,
                    UserId = userId,
                    RatingValue = ratingValue
                };
                _ratingRepository.AddRating(rating);
            }
            else
            {
                rating.RatingValue = ratingValue;
                _ratingRepository.Submit();
            }

            return GetRatingStats(productId);
        }

        public RatingResponse GetRatingToDetailsView(string userId, int productId)
        {
            var rating = _ratingRepository.GetRating(userId, productId);
            var ratingStats = GetRatingStats(productId);
            return new RatingResponse
            {
                RatingStats = ratingStats,
                UserRatingValue = rating?.RatingValue
            };
        }

        private RatingStats GetRatingStats(int productId)
        {
            var listOfRatings = _ratingRepository.GetRatingsByProductId(productId);
            var ratingsQuantity = listOfRatings.Count;
            var sumOfRatings = listOfRatings
                .Sum(r => r.RatingValue);
            var averageOfRatings = Math.Round((double)sumOfRatings / ratingsQuantity, 2);

            return new RatingStats
            {
                AverageOfRatings = averageOfRatings,
                RatingsQuantity = ratingsQuantity
            };
        }
    }
}
