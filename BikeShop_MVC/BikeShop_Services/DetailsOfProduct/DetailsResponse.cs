using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop_Services.DetailsOfProduct
{
    public class DetailsResponse
    {
        public ProductDetailsViewModel ProductDetails { get; set; }

        public int? UserRatingValue { get; set; }

        public int RatingsQuantity { get; set; }

        public double AverageOfRatings { get; set; }
    }
}
