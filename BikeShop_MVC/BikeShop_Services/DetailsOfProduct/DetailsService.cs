using BikeShop_DAL.Repositories;
using AutoMapper;
using BikeShop_Services.Ratings;

namespace BikeShop_Services.DetailsOfProduct
{
    public class DetailsService : IDetailsService
    {
        private readonly IProductRepository _productRepository;
        private readonly IRatingService _ratingService;

        public DetailsService(IProductRepository productRepository, IRatingService ratingService)
        {
            _productRepository = productRepository;
            _ratingService = ratingService;
        }

        public DetailsResponse GetProductDetails(int productId, string userId)
        {
            var ratingResult = _ratingService.GetRatingToDetailsView(userId, productId);

            return new DetailsResponse
            {
                ProductDetails = Mapper.Map<ProductDetailsViewModel>(_productRepository.GetProductById(productId)),
                UserRatingValue = ratingResult.UserRatingValue,
                AverageOfRatings = ratingResult.RatingStats.AverageOfRatings,
                RatingsQuantity = ratingResult.RatingStats.RatingsQuantity
            }; 
        }
    }
}
