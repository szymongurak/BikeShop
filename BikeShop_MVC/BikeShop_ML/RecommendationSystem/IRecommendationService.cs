using System.Collections.Generic;
using Microsoft.ML.Legacy;
using BikeShop_DAL.Models;
using System.Threading.Tasks;

namespace BikeShop_ML.RecommendationSystem
{
    public interface IRecommendationService
    {
        List<Product> GetRecommendedProducts(string userId);

        Task UpdateRecommendationSystem(string userId);

        Task<PredictionModel<RatingForCommonModel, RatingPrediction>> TrainCommonModel();

        Task UpdateCommonModel(string userId);

        bool UserHasAdditionalData(string userId);
    }
}
