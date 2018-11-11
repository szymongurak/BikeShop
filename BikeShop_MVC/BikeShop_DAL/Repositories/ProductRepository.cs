using System.Collections.Generic;
using System.Linq;
using BikeShop_DAL.Data;
using BikeShop_DAL.Models;

namespace BikeShop_DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProductRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public List<Product> GetAllProducts()
        {
           return _applicationDbContext.Products.ToList();
        }

        public Product GetProductById(int productId)
        {
            return _applicationDbContext.Products
                .Find(productId);
        }

        public void AddNewProduct(Product product)
        {
            _applicationDbContext.Products.Add(product);
            _applicationDbContext.SaveChanges();
        }

        public List<Product> GetProductsByCategory (int categoryId)
        {
            var filteredList = _applicationDbContext.Products
                .Where(p => p.CategoryId == categoryId)
                .ToList();
            return filteredList;
        }

        public void UpdateProduct(Product product)
        {
            var foundProduct = _applicationDbContext.Products
                .Where(p => p.Id == product.Id)
                .FirstOrDefault();
            if (foundProduct != null)
            {
                foundProduct.Name = product.Name;
                foundProduct.Manufacturer = product.Manufacturer;
                foundProduct.Description = product.Description;
                foundProduct.Quantity = product.Quantity;
                foundProduct.Price = product.Price;
                foundProduct.CategoryId = product.CategoryId;
                _applicationDbContext.SaveChanges();
            }
        }

        public void DeleteProduct(int productId)
        {
            var foundProduct = _applicationDbContext.Products
                .Where(p => p.Id == productId)
                .FirstOrDefault();
            if (foundProduct != null)
            {
                _applicationDbContext.Products.Remove(foundProduct);
                _applicationDbContext.SaveChanges();
            }
        }

    }
}
