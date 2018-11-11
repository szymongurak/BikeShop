using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BikeShop_DAL.Data;
using BikeShop_DAL.Models;

namespace BikeShop_DAL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public List<Category> GetAllCategories()
        {
            return _applicationDbContext.Categories.ToList();
        }

        public Category GetCategoryById(int categoryId)
        {
            return _applicationDbContext.Categories
                .Find(categoryId);
        }
    }
}
