using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop_Services.DetailsOfProduct
{
    public interface IDetailsService
    {
        DetailsResponse GetProductDetails(int productId, string userId);
    }
}
