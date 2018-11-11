using System.Collections.Generic;

namespace BikeShop_DAL.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public string Picture { get; set; }

        public bool Recommended { get; set; }

        public virtual Category Category { get; set; }

        public virtual int CategoryId { get; set; }

        public virtual ICollection<OrderPosition> OrderPositions { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
