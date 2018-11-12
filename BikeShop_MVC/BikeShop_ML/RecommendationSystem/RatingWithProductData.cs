using Microsoft.ML.Runtime.Api;

namespace BikeShop_ML.RecommendationSystem
{
    public class RatingWithProductData
    {
        [Column("0")]
        public int ProductId { get; set; }

        [Column("1")]
        public float RatingValue { get; set; }

        [Column("2")]
        public string Name { get; set; }

        [Column("3")]
        public string Manufacturer { get; set; }

        [Column("4")]
        public float Price { get; set; }

        [Column("5")]
        public string Category { get; set; }
    }
}
