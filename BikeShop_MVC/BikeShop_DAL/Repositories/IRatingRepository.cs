using System;
using System.Collections.Generic;
using System.Text;
using BikeShop_DAL.Models;

namespace BikeShop_DAL.Repositories
{
    public interface IRatingRepository
    {
        Rating GetRating(string userId, int productId);

        List<Rating> GetRatingsByProductId(int productId);

        void AddRating(Rating rating);

        void Submit();
    }
}
