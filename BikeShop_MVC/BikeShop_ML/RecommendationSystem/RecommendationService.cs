using System.Collections.Generic;
using BikeShop_DAL.Repositories;
using Microsoft.ML.Legacy;
using Microsoft.ML.Legacy.Data;
using Microsoft.ML.Legacy.Trainers;
using Microsoft.ML.Legacy.Transforms;
using System.IO;
using System.Linq;
using BikeShop_DAL.Models;
using System.Threading.Tasks;

namespace BikeShop_ML.RecommendationSystem
{
    public class RecommendationService : IRecommendationService
    {
        private readonly IRecommendationRepository _recommendationRepository;
        private readonly IUserRepository _userRepository;

        public RecommendationService(IRecommendationRepository recommendationRepository, IUserRepository userRepository)
        {
            _recommendationRepository = recommendationRepository;
            _userRepository = userRepository;
        }

        private List<RatingWithProductData> GetProductsWithCategoryName(string userId)
        {
            var listOfProducts = _recommendationRepository.GetListOfProduct();
            var listOfRatings = _recommendationRepository.GetListOfRating(userId);

            var listWithoutRatedProducts = listOfProducts
                .Where(p => !listOfRatings.Any(r => r.ProductId == p.Id))
                .ToList();

            List<RatingWithProductData> resultList = new List<RatingWithProductData>();

            foreach (var product in listWithoutRatedProducts)
            {
                resultList.Add(
                new RatingWithProductData
                {
                    ProductId = product.Id,
                    Name = product.Name,
                    Manufacturer = product.Manufacturer,
                    Price = (float)product.Price,
                    Category = product.Category.Name
                });
            }
            return resultList;
        }

        private List<RatingForCommonModel> GetProductsWithCategoryNameAndUserData(string userId)
        {
            var listOfProducts = _recommendationRepository.GetListOfProduct();
            var userData = _userRepository.GetUserById(userId);

            List<RatingForCommonModel> resultList = new List<RatingForCommonModel>();

            foreach (var product in listOfProducts)
            {
                resultList.Add(
                new RatingForCommonModel
                {
                    ProductId = product.Id,
                    Name = product.Name,
                    Manufacturer = product.Manufacturer,
                    Price = (float)product.Price,
                    Category = product.Category.Name,
                    Age = (float)userData.Age,
                    Interests = (float)userData.Interests,
                    LevelOfAdvancement = (float)userData.LevelOfAdvancement
                });
            }
            return resultList;
        }

        private List<RatingWithProductData> GetRatingsWithProductsData(string userId)
        {
            var listOfRatings = _recommendationRepository.GetListOfRating(userId);

            List<RatingWithProductData> resultList = new List<RatingWithProductData>();

            foreach(var rating in listOfRatings)
            {
                resultList.Add(
                new RatingWithProductData
                {
                    ProductId = rating.ProductId,
                    RatingValue = (float)rating.RatingValue,
                    Name = rating.Product.Name,
                    Manufacturer = rating.Product.Manufacturer,
                    Price = (float)rating.Product.Price,
                    Category = rating.Product.Category.Name
                });
            }
            return resultList;
        }

        private List<RatingForCommonModel> GetRatingsWithProductsAndUsersData()
        {
            var listOfRatings = _recommendationRepository.GetFullListOfRating();

            List<RatingForCommonModel> resultList = new List<RatingForCommonModel>();

            foreach (var rating in listOfRatings)
            {
                if(rating.User.Age!=0&&rating.User.Interests!=0&&rating.User.LevelOfAdvancement!=0)
                {
                    resultList.Add(
                    new RatingForCommonModel
                    {
                        ProductId = rating.ProductId,
                        RatingValue = (float)rating.RatingValue,
                        Name = rating.Product.Name,
                        Manufacturer = rating.Product.Manufacturer,
                        Price = (float)rating.Product.Price,
                        Category = rating.Product.Category.Name,
                        Age = (float)rating.User.Age,
                        Interests = (float)rating.User.Interests,
                        LevelOfAdvancement = (float)rating.User.LevelOfAdvancement
                    });
                }
            }
            return resultList;
        }

        public async Task<PredictionModel<RatingForCommonModel, RatingPrediction>> TrainCommonModel()
        {
            var data = GetRatingsWithProductsAndUsersData();
            var collection = CollectionDataSource.Create(data);

            string _modelPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "BikeShop_MVC", "BikeShop_ML", "Data", "CommonModel.zip");

            var pipeline = new LearningPipeline();
            pipeline.Add(collection);
            pipeline.Add(new ColumnCopier(("RatingValue", "Label")));
            pipeline.Add(new CategoricalOneHotVectorizer("Category", "Manufacturer"));
            pipeline.Add(new ColumnConcatenator("Features", "Category", "Price", "Manufacturer", "Age", "Interests", "LevelOfAdvancement"));
            pipeline.Add(new FastTreeRegressor());

            var model = pipeline.Train<RatingForCommonModel, RatingPrediction>();
            await model.WriteAsync(_modelPath);
            return model;
        }

        private async Task<PredictionModel<RatingWithProductData, RatingPrediction>> Train(string userId)
        {
            var data = GetRatingsWithProductsData(userId);
            var collection = CollectionDataSource.Create(data);

            string _modelPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "BikeShop_MVC", "BikeShop_ML", "Data", $"{userId}.zip");

            var pipeline = new LearningPipeline();
            pipeline.Add(collection);
            pipeline.Add(new ColumnCopier(("RatingValue", "Label")));
            pipeline.Add(new CategoricalOneHotVectorizer("Category", "Manufacturer"));
            pipeline.Add(new ColumnConcatenator("Features", "Category", "Price", "Manufacturer"));
            pipeline.Add(new FastTreeRegressor());

            var model = pipeline.Train<RatingWithProductData, RatingPrediction>();
            await model.WriteAsync(_modelPath);
            return model;
        }

        public List<Product> GetRecommendedProducts(string userId)
        {
            return _recommendationRepository.GetRecommendedProducts(userId);
        }

        public async Task UpdateCommonModel(string userId)
        {
            string _modelPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "BikeShop_MVC", "BikeShop_ML", "Data", "CommonModel.zip");
            var model = await PredictionModel.ReadAsync<RatingForCommonModel, RatingPrediction>(_modelPath);
            List<RatingPrediction> ratingList = new List<RatingPrediction>();
            var listOfProducts = GetProductsWithCategoryNameAndUserData(userId);
            foreach (var product in listOfProducts)
            {
                var predicatedRating = model.Predict(product);
                ratingList.Add(predicatedRating);
            }
            var productWithTheHighestRatings = ratingList
                .OrderByDescending(r => r.RatingValue)
                .Take(3)
                .ToList();
            _recommendationRepository.RemoveRecommendation(userId);
            foreach (var recommendation in productWithTheHighestRatings)
            {
                _recommendationRepository.AddRecommendation(recommendation.ProductId, userId);
            }
            _recommendationRepository.Submit();
        }

        public async Task UpdateRecommendationSystem(string userId)
        {
            var model = await Train(userId);
            List<float> fakeRatingList = new List<float>();
            List<RatingPrediction> ratingList = new List<RatingPrediction>();
            var listOfProducts = GetProductsWithCategoryName(userId);
            foreach (var product in listOfProducts)
            {
                var predicatedRating = model.Predict(product);
                ratingList.Add(predicatedRating);
                fakeRatingList.Add(predicatedRating.RatingValue);
            }
            var productWithTheHighestRatings = ratingList
                .OrderByDescending(r => r.RatingValue)
                .Take(3)
                .ToList();
            _recommendationRepository.RemoveRecommendation(userId);
            foreach (var recommendation in productWithTheHighestRatings)
            {
                _recommendationRepository.AddRecommendation(recommendation.ProductId, userId);
            }
            _recommendationRepository.Submit();
        }

        public bool UserHasAdditionalData(string userId)
        {
            var user = _userRepository.GetUserById(userId);
            if (user.Age != null && user.Interests != 0 && user.LevelOfAdvancement != 0)
            {
                return true;
            }
            return false;
        }
    }
}
