using BikeShop_DAL.Models;
using BikeShop_Services.Paging;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace BikeShop_Services.Products
{
    public class ProductListResponse
    {
        public PagedResponse<ProductViewModel> PagedResponse { get; set; }

        public List<CategoryViewModel> CategoryList { get; set; }

        public string CategoryName { get; set; }

        public int? CategoryId { get; set; }

        public string SearchedProduct { get; set; }

        public int MaxPrice { get; set; }

        public int MinPrice { get; set; }

        public int CurrentSetMinPrice { get; set; }

        public int CurrentSetMaxPrice { get; set; }

        public string GetCurrentUrl(IUrlHelper urlHelper)
        {
            var parms = new Dictionary<string, string>();
            if (CategoryId.HasValue)
            {
                parms.Add("categoryId", CategoryId.ToString());
            }
            if (!String.IsNullOrEmpty(SearchedProduct))
            {
                parms.Add("searchedProduct", SearchedProduct);
            }
            if (MinPrice != CurrentSetMinPrice || MaxPrice != CurrentSetMaxPrice)
            {
                parms.Add("minPrice", CurrentSetMinPrice.ToString());
                parms.Add("maxPrice", CurrentSetMaxPrice.ToString());
            }
            return urlHelper.Action("Index", "Product", parms);
        }
    }
}
