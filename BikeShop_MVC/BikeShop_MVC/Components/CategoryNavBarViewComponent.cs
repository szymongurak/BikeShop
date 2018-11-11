using Microsoft.AspNetCore.Mvc;
using BikeShop_Services.Products;

namespace BikeShop_MVC.Components
{
    public class CategoryNavBarViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryNavBarViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_categoryService.GetListOfCategories());
        }
    }


}
