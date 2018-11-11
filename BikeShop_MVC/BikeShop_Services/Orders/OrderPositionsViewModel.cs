namespace BikeShop_Services.Orders
{
    public class OrderPositionsViewModel
    {
        public int Quantity { get; set; }

        public string NameOfProduct { get; set; }

        public decimal Price { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
