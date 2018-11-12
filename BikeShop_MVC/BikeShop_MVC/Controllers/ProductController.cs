using BikeShop_DAL.Models;
using BikeShop_Services.DetailsOfProduct;
using BikeShop_Services.Products;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using BikeShop_Services.Ratings;
using BikeShop_Services.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace BikeShop_MVC.Controllers
{
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IDetailsService _detailsService;
        private readonly UserManager<User> _userManager;
        private readonly IRatingService _ratingService;

        public ProductController(IProductService productService, ICategoryService categoryService, IDetailsService detailsService, UserManager<User> userManager, IRatingService ratingService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _detailsService = detailsService;
            _userManager = userManager;
            _ratingService = ratingService;
        }

        [Route("", Name ="AllProducts")]
        [Route("Category/{categoryId}")]
        public IActionResult Index(int? categoryId = null, string searchedProduct = null, int? minPrice = null, int? maxPrice = null, int pageNo = 1)
        {
            ProductListRequest productListRequest = new ProductListRequest
            {
                CatgoryId = categoryId,
                SearchedProducts = searchedProduct,
                MinPrice = minPrice,
                MaxPrice = maxPrice,
                Page = pageNo
            };
            var toReturn = _productService.GetListOfProducts(productListRequest);
            return View("Index", toReturn);
        }

        [Route("{productId}/[action]")]
        public IActionResult Details(int productId)
        {
            return View("Details", _detailsService.GetProductDetails(productId, _userManager.GetUserId(this.User)));
        }

        [Authorize]
        [Route("[action]")]
        public OperationResult<RatingStats> SaveRating(int productId, int ratingValue)
        {
            var result = _ratingService.SaveRating(ratingValue, _userManager.GetUserId(this.User), productId);
            return OperationResult<RatingStats>.Success(result);
        }
    }
}
