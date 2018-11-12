using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop_DAL.Models
{
    public class Recommendation
    {
        public int RecommendationId { get; set; }

        public virtual Product Product { get; set; }

        public virtual int ProductId { get; set; }

        public virtual User User { get; set; }

        public virtual string UserId { get; set; }
    }
}
