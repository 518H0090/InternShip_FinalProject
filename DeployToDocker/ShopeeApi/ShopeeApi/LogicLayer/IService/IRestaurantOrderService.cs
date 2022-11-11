using ShopeeApi.Dtos.Request;
using ShopeeApi.Dtos.Response;
using ShopeeApi.Service;

namespace ShopeeApi.IService
{
    public interface IRestaurantOrderService
    {
        Task<ServiceResponse<ResponseRestaurantOrder>> NewRestaurantOrder(RequestAddResOrder request);

        Task<ServiceResponse<ResponseRestaurantOrder>> DeleteRestaurantOrder(RequestDeleteRestaurantOrder request);

        Task<ServiceResponse<IEnumerable<ResponseRestaurantOrder>>> GetAllRestaurantOrder(int restaurantId, string userName);
    }
}