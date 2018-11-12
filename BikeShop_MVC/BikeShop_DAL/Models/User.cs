using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using BikeShop_DAL.Models.Enums;

namespace BikeShop_DAL.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public int? Age { get; set; }

        public Interests Interests { get; set; }

        public LevelOfAdvancement LevelOfAdvancement { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }

        public virtual ICollection<Recommendation> Recommendations { get; set; }
    }
}
