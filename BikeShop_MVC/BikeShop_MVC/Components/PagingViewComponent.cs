using Microsoft.AspNetCore.Mvc;
using BikeShop_Services.Paging;
using BikeShop_DAL.Models;
using System.Collections.Generic;

namespace BikeShop_MVC.Components
{
    public class PagingViewComponent : ViewComponent
    {
        private readonly IPagingService _pagingService;

        public PagingViewComponent(IPagingService pagingService)
        {
            _pagingService = pagingService;
        }

        public IViewComponentResult Invoke(string url, int pageSize, int currentPage)
        {
            PagingViewComponentResult pagingViewComponentResult = new PagingViewComponentResult
            {
                Url = url,
                PageCount = pageSize,
                CurrentPage = currentPage
            };
            return View(pagingViewComponentResult);
        }
    }
}
