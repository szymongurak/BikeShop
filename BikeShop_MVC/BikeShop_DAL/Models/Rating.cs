using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop_DAL.Models
{
    public class Rating
    {
        public int RatingId { get; set; }

        public int RatingValue { get; set; }

        public virtual Product Product { get; set; }

        public virtual int ProductId { get; set; }

        public virtual User User { get; set; }

        public virtual string UserId { get; set; }
    }
}
