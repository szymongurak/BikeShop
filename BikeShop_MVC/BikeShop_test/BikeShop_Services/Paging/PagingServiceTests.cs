using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using NSubstitute;
using FluentAssertions;
using BikeShop_DAL.Models;
using BikeShop_Services.Paging;
using Microsoft.Extensions.Configuration;
using BikeShop_Services.Products;

namespace BikeShop_test.BikeShop_Services.Paging
{
    public class PagingServiceTests
    {
        [Fact]
        public void GetOnePageOfProducts_ListContainsSixProductsAndPageSizeIsThree_ResultContainsListOfThreeProductsAndPageCountEqualsTwo()
        {
            //Arrange
            List<Product> list = fullListOfProducts();
            var configuration = Substitute.For<IConfiguration>();
            configuration.GetSection("PageSize").Value.Returns("3");
            var sut = new PagingService(configuration);

            //Act
            var result = sut.GetOnePageOfProducts<Product>(list, 1);

            //Assert
            result.Should().BeOfType(typeof(PagedResponse<Product>));
            result.ListOfItems.Count.Should().Be(3);
            result.PageCount.Should().Be(2);
            result.CurrentPage.Should().Be(1);
        }

        [Fact]
        public void GetOnePageOfProducts_ListContainsSevenProductsAndPageSizeIsSix_ResultContainsPageCountEqualsTwo()
        {
            //Arrange
            List<Product> list = fullListOfProducts();
            list.Add(
                new Product
                {
                    Id = 7,
                    CategoryId = 1,
                    Name = "Monarch Plus RC3 Rear Shock",
                    Price = 386.49M,
                    Description = "",
                    Manufacturer = "",
                    Quantity = 15
                });
            var configuration = Substitute.For<IConfiguration>();
            configuration.GetSection("PageSize").Value.Returns("6");
            var sut = new PagingService(configuration);

            //Act
            var result = sut.GetOnePageOfProducts<Product>(list, 1);

            //Assert
            result.Should().BeOfType(typeof(PagedResponse<Product>));
            result.PageCount.Should().Be(2);
            result.CurrentPage.Should().Be(1);
        }

        [Fact]
        public void GetOnePageOfProducts_ListOfProductsIsEmpty_ResultListIsEmptyAndPageCountIsOne()
        {
            //Arrange
            List<Product> list = new List<Product>();
            var configuration = Substitute.For<IConfiguration>();
            configuration.GetSection("PageSize").Value.Returns("4");
            var sut = new PagingService(configuration);

            //Act
            var result = sut.GetOnePageOfProducts<Product>(list, 1);

            //Assert
            result.Should().BeOfType(typeof(PagedResponse<Product>));
            result.ListOfItems.Count.Should().Be(0);
            result.PageCount.Should().Be(1);
            result.CurrentPage.Should().Be(1);
        }


        [Fact]
        public void GetOnePageOfProducts_PangeNumberIsBiggerThanMaxPageNumber_ResultListIsEmptyAndCurrentPageIsThree()
        {
            //Arrange
            List<Product> list = fullListOfProducts();
            var configuration = Substitute.For<IConfiguration>();
            configuration.GetSection("PageSize").Value.Returns("4");
            var sut = new PagingService(configuration);

            //Act
            var result = sut.GetOnePageOfProducts<Product>(list, 3);

            //Assert
            result.Should().BeOfType(typeof(PagedResponse<Product>));
            result.ListOfItems.Count.Should().Be(0);
            result.PageCount.Should().Be(2);
            result.CurrentPage.Should().Be(3);
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
    }
}
