using AutoMapper;
using BikeShop_DAL.Repositories;
using BikeShop_Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BikeShop_Services.Products
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public CategoryListResponse GetListOfCategories()
        {
            return new CategoryListResponse
            {
                CategoryList = Mapper.Map<List<CategoryViewModel>>(_categoryRepository.GetAllCategories())
            };
        }
    }
}
