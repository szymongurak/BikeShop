using BikeShop_Services.Products;
using BikeShop_DAL.Repositories;
using Xunit;
using NSubstitute;
using FluentAssertions;
using System.Collections.Generic;
using BikeShop_DAL.Models;
using BikeShop_Services.Paging;
using AutoMapper;

namespace BikeShop_test.BikeShop_Services.Products
{
    public class ProductServiceTests
    {
        [Fact]
        public void GetListOfProducts_FilterWithFullRangeOfPrice_ResultContainsAllProducts()
        {
            AutoMapper.Mapper.Reset();
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<ProductMappingProfile>();

            });

            List<Product> productList = fullListOfProducts();

            ProductListRequest productListRequest = new ProductListRequest()
            {
                CatgoryId = null,
                MaxPrice = null,
                MinPrice = null,
                SearchedProducts = null,
                Page = 1
            };

            PagedResponse<ProductViewModel> pagingListResponse = new PagedResponse<ProductViewModel>()
            {
                ListOfItems = Mapper.Map<List<ProductViewModel>>(productList),
                CurrentPage = 1,
                PageCount = 1
            };

            //Arrange
            var categoryRepository = Substitute.For<ICategoryRepository>();
            var productRepository = Substitute.For<IProductRepository>();
            var pagingService = Substitute.For<IPagingService>();
            productRepository.GetAllProducts().Returns(productList);
            pagingService.GetOnePageOfProducts<ProductViewModel>(Arg.Any<List<ProductViewModel>>(), 1).Returns(pagingListResponse);
            var sut = new ProductService(productRepository, categoryRepository, pagingService);

            //Act
            var firstResult = sut.GetListOfProducts(productListRequest);
            productListRequest.MaxPrice = firstResult.MaxPrice;
            productListRequest.MinPrice = firstResult.MinPrice;
            var secondResult = sut.GetListOfProducts(productListRequest);

            //Assert
            secondResult.Should().BeOfType(typeof(ProductListResponse));
            secondResult.PagedResponse.ListOfItems.Count.Should().Be(6);
        }

        [Fact]
        public void GetListOfProducts_FilterWithRangeOfPriceFromCategory_ResultContainsAllProductsFromCategory()
        {
            AutoMapper.Mapper.Reset();
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<ProductMappingProfile>();

            });

            List<Product> productList = fullListOfProducts();

            List<Category> categoryList = fullListOfCategory();

            ProductListRequest productListRequest = new ProductListRequest()
            {
                CatgoryId = 1,
                MaxPrice = null,
                MinPrice = null,
                SearchedProducts = null,
                Page = 1
            };

            var productListFromCategory = new List<Product>();
            productListFromCategory.Add(productList[0]);
            productListFromCategory.Add(productList[1]);
            productListFromCategory.Add(productList[2]);
            productListFromCategory.Add(productList[3]);

            PagedResponse<ProductViewModel> pagingListResponse = new PagedResponse<ProductViewModel>()
            {
                ListOfItems = Mapper.Map<List<ProductViewModel>>(productListFromCategory),
                CurrentPage = 1,
                PageCount = 1
            };

            //Arrange
            var categoryRepository = Substitute.For<ICategoryRepository>();
            var productRepository = Substitute.For<IProductRepository>();
            var pagingService = Substitute.For<IPagingService>();
            productRepository.GetProductsByCategory(1).Returns(productListFromCategory);
            categoryRepository.GetCategoryById(1).Returns(categoryList[0]);
            pagingService.GetOnePageOfProducts<ProductViewModel>(Arg.Any<List<ProductViewModel>>(), 1).Returns(pagingListResponse);
            var sut = new ProductService(productRepository, categoryRepository, pagingService);

            //Act
            var firstResult = sut.GetListOfProducts(productListRequest);
            productListRequest.MaxPrice = firstResult.MaxPrice;
            productListRequest.MinPrice = firstResult.MinPrice;
            var secondResult = sut.GetListOfProducts(productListRequest);

            //Assert
            secondResult.Should().BeOfType(typeof(ProductListResponse));
            secondResult.PagedResponse.ListOfItems.Count.Should().Be(4);
        }

        private List<Product> fullListOfProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "SLX disc brake",
                    Price = 289.99M,
                    Description ="",
                    Manufacturer  ="",
                    Quantity = 5
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "NS Helmet",
                    Price = 356.0M,
                    Description ="",
                    Manufacturer  ="",
                    Quantity = 5
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Name = "XTR brake",
                    Price = 423.45M,
                    Description ="",
                    Manufacturer  ="",
                    Quantity = 5
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 1,
                    Name = "NS Frame",
                    Price = 899.99M,
                    Description ="",
                    Manufacturer  ="",
                    Quantity = 5
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Name = "NS Bike",
                    Price = 1899.99M,
                    Description ="",
                    Manufacturer  ="",
                    Quantity = 5
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Name = "Giant Bike",
                    Price = 2899.99M,
                    Description ="",
                    Manufacturer  ="",
                    Quantity = 5
                }
            };
        }

        private List<Category> fullListOfCategory()
        {
            return new List<Category>()
            {
                new Category
                {
                    Id = 1,
                    Name = "Bike components",
                    Description = "Components to your bike"
                },
                new Category
                {
                    Id = 2,
                    Name = "Bikes",
                    Description = "Complete bikes"
                }
            };
        }
    }
}
