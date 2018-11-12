using System.Threading.Tasks;

namespace BikeShop_Services.Ratings
{
    public interface IRatingService
    {
        RatingStats SaveRating(int ratingValue, string userId, int productId);

        RatingResponse GetRatingToDetailsView(string userId, int productId);
    }
}
