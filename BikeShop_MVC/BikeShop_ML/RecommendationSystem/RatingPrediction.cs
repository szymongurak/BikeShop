using Microsoft.ML.Runtime.Api;

namespace BikeShop_ML.RecommendationSystem
{
    public class RatingPrediction
    {
        [ColumnName("Score")]
        public float RatingValue { get; set; }

        public int ProductId { get; set; }
    }
}
