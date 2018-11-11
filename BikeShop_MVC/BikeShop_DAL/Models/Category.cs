using System.Collections.Generic;

namespace BikeShop_DAL.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
