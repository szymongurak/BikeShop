using System.Collections.Generic;
using BikeShop_DAL.Models;
using BikeShop_DAL.Repositories;
using AutoMapper;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System;
using BikeShop_Services.Paging;

namespace BikeShop_Services.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPagingService _pagingService;

        public ProductService(IProductRepository productRepository, ICategoryRepository categoryRepository, IPagingService pagingService)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _pagingService = pagingService;
        }

        public ProductListResponse GetListOfProducts(ProductListRequest productListRequest)
        {
            List<Product> filteredList;
            var productListResponse = new ProductListResponse();
            if (productListRequest.CatgoryId != null)
            {
                filteredList = _productRepository.GetProductsByCategory(productListRequest.CatgoryId.Value);
            }
            else
            {
                filteredList = _productRepository.GetAllProducts();
            }

            SetMinMaxPrice(productListResponse, filteredList, productListRequest.MinPrice, productListRequest.MaxPrice);

            if (!String.IsNullOrEmpty(productListRequest.SearchedProducts))
            {
                filteredList = NameFilter(productListRequest.SearchedProducts, filteredList);
            }

            if (productListRequest.MinPrice != null && productListRequest.MaxPrice != null)
            {
                filteredList = PriceFilter(productListRequest.MinPrice.Value, productListRequest.MaxPrice.Value, filteredList);
            }

            var listToPaging = Mapper.Map<List<ProductViewModel>>(filteredList);

            var pagingResult = _pagingService.GetOnePageOfProducts(listToPaging, productListRequest.Page);

            productListResponse.PagedResponse = pagingResult;
            productListResponse.CategoryList = Mapper.Map<List<CategoryViewModel>>(_categoryRepository.GetAllCategories());
            productListResponse.SearchedProduct = productListRequest.SearchedProducts;

            if (productListRequest.CatgoryId.HasValue)
            {
                productListResponse.CategoryName = Mapper.Map<CategoryViewModel>(_categoryRepository.GetCategoryById(productListRequest.CatgoryId.Value)).Name;
                productListResponse.CategoryId = productListRequest.CatgoryId;
            }
    
            return productListResponse;
        }

        private List<Product> NameFilter(string searchedPhrase, List<Product> list)
        {
            if (String.IsNullOrEmpty(searchedPhrase))
            {
                return list;
            }

            var filteredList = list
                .Where(p => searchedPhrase == null || p.Name.ToLowerInvariant().Contains(searchedPhrase.ToLowerInvariant()))
                .ToList();
            return filteredList;
        }

        private List<Product> PriceFilter(int minPrice, int maxPrice, List<Product> list)
        {
            return list
                .Where(p => p.Price >= (decimal)minPrice && p.Price <= (decimal)maxPrice)
                .ToList();
        }

        private void SetMinMaxPrice(ProductListResponse productListResponse, List<Product> list, int? minPrice, int? maxPrice)
        {
            productListResponse.MinPrice = (int)list.Min(p => p.Price);
            productListResponse.MaxPrice = (int)Math.Ceiling(list.Max(p => p.Price));

            if (minPrice.HasValue && maxPrice.HasValue)
            {
                productListResponse.CurrentSetMinPrice = minPrice.Value;
                productListResponse.CurrentSetMaxPrice = maxPrice.Value;
            }
            else
            {
                productListResponse.CurrentSetMinPrice = productListResponse.MinPrice;
                productListResponse.CurrentSetMaxPrice = productListResponse.MaxPrice;
            }
        }
    }
}
