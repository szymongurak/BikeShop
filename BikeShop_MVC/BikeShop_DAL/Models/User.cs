using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BikeShop_DAL.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
