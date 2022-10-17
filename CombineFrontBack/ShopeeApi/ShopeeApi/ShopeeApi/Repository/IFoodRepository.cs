using ShopeeApi.Models;

namespace ShopeeApi.Repository
{
    public interface IFoodRepository
    {
        Task<Food> CreateFood(Food request);

        Task<IEnumerable<Food>> GetAllFood();

        Task<int> AllIndexPagination();

        Task<IEnumerable<Food>> GetAllFoodPagination(int indexPage);

        Task<int> AllIndexPaginationWithKeywords(string keywords);

        Task<IEnumerable<Food>> GetAllFoodPaginationWithKeywords(int indexPage, string keywords);

        Task<IEnumerable<Food>> GetAllFoodInRestaurant(Food request);

        Task<Food> GetFoodById(Food request);

        Task<Food> GetFoodInRestaurantById(Food request);

        Task<bool> ExistsFoodInRestaurant(Food request);

        Task<bool> ExistsRestaurant(Food request);

        Task<bool> DeleteFood(Food request);

        Task<Food> UpdateFood(Food request);
    }
}