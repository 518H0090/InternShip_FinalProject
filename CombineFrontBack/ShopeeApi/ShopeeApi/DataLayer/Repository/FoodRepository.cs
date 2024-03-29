﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ShopeeApi.Datas;
using ShopeeApi.IRepository;
using ShopeeApi.Models;

namespace ShopeeApi.Repository
{
    public class FoodRepository : IFoodRepository
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;
        private readonly int _totalFoodGenerate;

        public FoodRepository(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
            _totalFoodGenerate = int.Parse(_configuration.GetSection("SetIndexPageForFood:NumberFoodGenerate").Value);
        }

        public async Task<int> AllIndexPagination()
        {
            double countTotalFoods = 0;
            int totalIndexPage = 0;

            await _context.Foods.ForEachAsync(element =>
            {
                countTotalFoods++;
            });

            totalIndexPage = (int)Math.Ceiling(countTotalFoods / _totalFoodGenerate);

            return totalIndexPage;
        }

        public async Task<int> AllIndexPaginationWithKeywords(string keywords)
        {
            double countTotalFoods = 0;
            int totalIndexPage = 0;

            await _context.Foods.Where(x => x.FoodTitle.ToLower().Contains(keywords.ToLower())).ForEachAsync(element =>
            {
                countTotalFoods++;
            });

            totalIndexPage = (int)Math.Ceiling(countTotalFoods / _totalFoodGenerate);

            return totalIndexPage;
        }

        public async Task<Food> CreateFood(Food request)
        {
            //Basic Temp Check Priceless In Visualize
            var findRestaurant = await _context.Restaurants.Where(x => x.RsId == request.RestaurantId)
                .FirstOrDefaultAsync();

            request.FoodPriceLess = request.FoodPrice - (int)findRestaurant.RsPromotion;

            var newFood = await _context.Foods.AddAsync(request);
            await _context.SaveChangesAsync();

            return newFood.Entity;
        }

        public async Task<bool> DeleteFood(Food request)
        {
            var findFood = await _context.Foods
                .FirstOrDefaultAsync(x => x.FoodId == request.FoodId && x.RestaurantId == request.RestaurantId);

            if (findFood == null)
            {
                return false;
            }

            _context.Foods.Remove(findFood);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ExistsFoodInRestaurant(Food request)
        {
            var findFoodInRes = await _context.Foods
                .FirstOrDefaultAsync(x => x.FoodTitle == request.FoodTitle && x.RestaurantId == request.RestaurantId);

            if (findFoodInRes == null)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> ExistsRestaurant(Food request)
        {
            var findRestaurant = await _context.Restaurants.FirstOrDefaultAsync(x => x.RsId == request.RestaurantId);

            if (findRestaurant == null)
            {
                return false;
            }

            return true;
        }

        public async Task<IEnumerable<Food>> GetAllFood()
        {
            return await _context.Foods.ToListAsync();
        }

        public async Task<IEnumerable<Food>> GetAllFoodInRestaurant(Food request)
        {
            return await _context.Foods.Where(f => f.RestaurantId == request.RestaurantId).ToListAsync();
        }

        public async Task<IEnumerable<Food>> GetAllFoodPagination(int indexPage)
        {
            int numberFoodGenerate = _totalFoodGenerate;
            int numberFoodSkip = _totalFoodGenerate * (indexPage - 1);

            if (indexPage > 1)
            {
                return await _context.Foods.Skip(numberFoodSkip).Take(numberFoodGenerate).ToListAsync();
            }
            else
            {
                return await _context.Foods.Take(numberFoodGenerate).ToListAsync();
            }
        }

        public async Task<IEnumerable<Food>> GetAllFoodPaginationWithKeywords(int indexPage, string keywords)
        {
            int numberFoodGenerate = _totalFoodGenerate;
            int numberFoodSkip = 15 * (indexPage - 1);

            if (indexPage > 1)
            {
                return await _context.Foods.Where(x => x.FoodTitle.ToLower().Contains(keywords.ToLower()))
                    .Skip(numberFoodSkip).Take(numberFoodGenerate).ToListAsync();
            }
            else
            {
                return await _context.Foods.Where(x => x.FoodTitle.ToLower().Contains(keywords.ToLower()))
                    .Take(numberFoodGenerate).ToListAsync();
            }
        }

        public async Task<Food> GetFoodById(Food request)
        {
            return await _context.Foods.FirstOrDefaultAsync(f => f.FoodId == request.FoodId);
        }

        public async Task<Food> GetFoodInRestaurantById(Food request)
        {
            return await _context.Foods.FirstOrDefaultAsync(f => f.FoodId == request.FoodId && f.RestaurantId == request.RestaurantId);
        }

        public async Task<Food> UpdateFood(Food request)
        {
            var findFood = await _context.Foods
                .FirstOrDefaultAsync(x => x.FoodId == request.FoodId && x.RestaurantId == request.RestaurantId);

            if (findFood == null)
            {
                return null;
            }

            findFood.FoodImageUrl = request.FoodImageUrl;
            findFood.FoodTitle = request.FoodTitle;
            findFood.FoodDescription = request.FoodDescription;
            findFood.FoodPrice = request.FoodPrice;
            findFood.FoodPriceLess = request.FoodPriceLess;

            var updatedFood = _context.Foods.Update(findFood);
            await _context.SaveChangesAsync();

            return updatedFood.Entity;
        }

        public async Task<int> AllIndexPaginationWithRestaurantType(string resType)
        {
            double countTotalFoods = 0;
            int totalIndexPage = 0;

            var listFood = new List<Food>();

            var processResType = resType.Replace("%2F", "/");

            var listRestaurant = await _context.Restaurants.Where(x => x.RsType == processResType).ToListAsync();

            listRestaurant.ForEach(element =>
            {
                var foodInItem = _context.Foods.Where(x => x.Restaurant == element).ToList();

                listFood.AddRange(foodInItem);
            });

            listFood.ForEach(element =>
            {
                countTotalFoods++;
            });

            totalIndexPage = (int)Math.Ceiling(countTotalFoods / _totalFoodGenerate);

            return totalIndexPage;
        }

        public async Task<IEnumerable<Food>> GetAllFoodPaginationWithRestaurantType(int indexPage, string resType)
        {
            var listFood = new List<Food>();

            var listRestaurant = await _context.Restaurants.Where(x => x.RsType == resType).ToListAsync();

            int numberFoodGenerate = _totalFoodGenerate;
            int numberFoodSkip = 15 * (indexPage - 1);

            listRestaurant.ForEach(element =>
            {
                var foodInItem = _context.Foods.Where(x => x.Restaurant == element).ToList();

                listFood.AddRange(foodInItem);
            });

            if (indexPage > 1)
            {
                return listFood.Skip(numberFoodSkip).Take(numberFoodGenerate).ToList();
            }
            else if (indexPage == 1)
            {
                return listFood.Take(numberFoodGenerate).ToList();
            }

            return null;
        }
    }
}