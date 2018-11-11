using BikeShop_DAL.Models;
using System.Collections.Generic;

namespace BikeShop_DAL.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
        Category GetCategoryById(int categoryId);
    }
}
