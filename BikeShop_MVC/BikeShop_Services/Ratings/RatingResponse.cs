namespace BikeShop_Services.Ratings
{
    public class RatingResponse
    {
        public int? UserRatingValue { get; set; }

        public RatingStats  RatingStats {get; set;}
    }
}
