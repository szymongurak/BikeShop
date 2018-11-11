using BikeShop_DAL.Models;
using System.Collections.Generic;

namespace BikeShop_DAL.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        List<Product> GetProductsByCategory(int categoryId);
        Product GetProductById(int productId);
        void AddNewProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
    }
}
