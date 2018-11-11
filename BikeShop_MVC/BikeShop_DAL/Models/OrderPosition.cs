
namespace BikeShop_DAL.Models
{
    public class OrderPosition
    {
        public int OrderPositionId { get; set; }

        public int Quantity { get; set; }

        public string NameOfProduct { get; set; }

        public decimal Price { get; set; }

        public decimal TotalPrice { get; set; }

        public virtual Order Order { get; set; }

        public virtual int OrderId { get; set; }

        public virtual Product Product { get; set; }

        public virtual int ProductId { get; set; }
    }
}
