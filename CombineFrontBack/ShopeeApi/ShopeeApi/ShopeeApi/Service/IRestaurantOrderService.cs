using ShopeeApi.Dtos;
using ShopeeApi.Models;
using ShopeeApi.Repository;

namespace ShopeeApi.Service
{
    public interface IRestaurantOrderService
    {
        Task<ServiceResponse<ResponseRestaurantOrder>> NewRestaurantOrder(RequestAddResOrder request);

        Task<ServiceResponse<ResponseRestaurantOrder>> DeleteRestaurantOrder(RequestDeleteRestaurantOrder request);

        Task<ServiceResponse<IEnumerable<ResponseRestaurantOrder>>> GetAllRestaurantOrder(int restaurantId, string userName);
    }
}
