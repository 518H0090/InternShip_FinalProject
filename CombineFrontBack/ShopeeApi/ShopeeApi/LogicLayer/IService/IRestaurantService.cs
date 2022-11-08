using ShopeeApi.Dtos.Request;
using ShopeeApi.Dtos.Response;
using ShopeeApi.Service;

namespace ShopeeApi.IService
{
    public interface IRestaurantService
    {
        Task<ServiceResponse<ResponseGetRestaurant>> CreateRestaurant(RequestAddRestaurant request);

        Task<ServiceResponse<IEnumerable<ResponseGetRestaurant>>> GetAllRestaurant();

        Task<ServiceResponse<IEnumerable<ResponseGetRestaurant>>> GetAllRestaurantTop9();

        Task<ServiceResponse<ResponseGetRestaurant>> GetRestaurantById(int ResId);

        Task<ServiceResponse<ResponseGetRestaurantWithId>> GetRestaurantByTitle(string resTitle);

        Task<ServiceResponse<ResponseGetRestaurantWithFoodTag>> GetRestaurantByIdWithTagAndFood(int ResId);

        Task<ServiceResponse<ResponseGetRestaurant>> UpdateRestaurant(int ResId, RequestEditRestaurant request);

        Task<ServiceResponse<string>> DeleteRestaurant(int ResId);

        Task<ServiceResponse<IEnumerable<ResponseGetRestaurantWithCategoryTag>>> GetAllRestaurantWithTag();

        Task<ServiceResponse<IEnumerable<ResponseGetRestaurantWithFood>>> GetAllRestaurantWithFood();

        Task<ServiceResponse<IEnumerable<ResponseGetRestaurantWithFoodTag>>> GetAllRestaurantWithFoodTag();
    }
}