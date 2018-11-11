using BikeShop_DAL.Models;
using System.Collections.Generic;

namespace BikeShop_Services.Products
{
    public interface IProductService
    {
        ProductListResponse GetListOfProducts(ProductListRequest productListRequest);
    }
}
