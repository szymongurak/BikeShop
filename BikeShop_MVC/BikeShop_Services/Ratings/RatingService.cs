using System;
using BikeShop_DAL.Models;
using BikeShop_DAL.Repositories;
using System.Linq;
using BikeShop_ML.RecommendationSystem;
using System.Threading.Tasks;
using Hangfire;

namespace BikeShop_Services.Ratings
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _ratingRepository;
        private readonly IRecommendationService _recommendationService;

        public RatingService(IRatingRepository ratingRepository, IRecommendationService recommendationService)
        {
            _ratingRepository = ratingRepository;
            _recommendationService = recommendationService;
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

            //_recommendationService.TrainCommonModel();
            //await _recommendationService.TrainCommonModel();
            BackgroundJob.Enqueue(() => _recommendationService.TrainCommonModel());
            //BackgroundJob.Enqueue(() => _recommendationService.UpdateCommonModel(userId));

            if (_ratingRepository.GetRatingsByUserId(userId).Count >= 20)
            {
                BackgroundJob.Enqueue(() => _recommendationService.UpdateRecommendationSystem(userId));
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
