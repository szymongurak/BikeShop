using Microsoft.ML.Runtime.Api;

namespace BikeShop_ML.RecommendationSystem
{
    public class RatingForCommonModel
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

        [Column("6")]
        public float Age { get; set; }

        [Column("7")]
        public float Interests { get; set; }

        [Column("8")]
        public float LevelOfAdvancement { get; set; }
    }
}
