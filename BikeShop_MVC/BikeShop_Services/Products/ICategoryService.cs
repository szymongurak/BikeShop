using System.Collections.Generic;
using BikeShop_DAL.Models;
using BikeShop_DAL.Repositories;
using AutoMapper;
using BikeShop_Services.Common;

namespace BikeShop_Services.Products
{
    public interface ICategoryService
    {
        CategoryListResponse GetListOfCategories();
    }
}
