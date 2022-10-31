using ShopeeApi.Dtos;
using ShopeeApi.Models;

namespace ShopeeApi.Repository
{
    public interface IRestaurantOrderRepository
    {
        Task<RestaurantOrder> NewRestaurantOrder(RequestAddResOrder request);

        Task<RestaurantOrder> UpdateRestaurantOrder(RequestUpdateResOrder request);

        Task<RestaurantOrder> UpdateRestaurantOrderDecrease(RequestUpdateResOrder request);

        Task<bool> ExistRecord(int restaurantId, string userName, string foodTitle);

        Task<IEnumerable<RestaurantOrder>> GetAllRestaurantOrder(int restaurantId, string userName);

        Task<RestaurantOrder> GetRestaurantOrderByFoodTitle(int restaurantId, string userName, string foodTitle);

        Task<bool> DeleteRestaurant(int restaurantId, string userName, string foodTitle);
    }
}
