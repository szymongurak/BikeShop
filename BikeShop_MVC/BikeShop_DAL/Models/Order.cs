using System;
using System.Collections.Generic;
using BikeShop_DAL.Models.Enums;

namespace BikeShop_DAL.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public OrderStatus StatusOfOrder { get; set; }

        public DateTime OrderDate { get; set; }

        public string TypeOfShipment { get; set; }

        public decimal CostOfShipment { get; set; }

        public decimal TotalCost { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public virtual User User { get; set; }

        public virtual string UserId { get; set; }

        public virtual ICollection<OrderPosition> OrderPositions { get; set; }
    }
}