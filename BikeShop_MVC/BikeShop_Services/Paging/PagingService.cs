using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BikeShop_Services.Paging
{
    public class PagingService : IPagingService
    {
        private readonly IConfiguration _configuration;

        public PagingService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public PagedResponse<T> GetOnePageOfProducts<T>(List<T> listOfItems, int page) where T : class
        {
            var rowCount = listOfItems.Count;
            var currentPage = page;
            var pageSize = 0;
            Int32.TryParse(_configuration.GetSection("PageSize").Value, out pageSize);
            var pageCount = (rowCount != 0) ? (int)Math.Ceiling((double)rowCount / pageSize) : 1;
            var skip = (currentPage - 1) * pageSize;
            listOfItems = listOfItems.Skip(skip).Take(pageSize).ToList();

            return new PagedResponse<T>
            {
                ListOfItems = listOfItems,
                PageCount = pageCount,
                CurrentPage = currentPage
            };
        }
    }
}
