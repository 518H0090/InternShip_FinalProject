using ShopeeApi.Dtos.Request;
using ShopeeApi.Dtos.Response;
using ShopeeApi.Service;

namespace ShopeeApi.IService
{
    public interface IFoodService
    {
        Task<ServiceResponse<ResponseGetFood>> CreateFood(RequestAddFood request);

        Task<ServiceResponse<IEnumerable<ResponseGetFood>>> GetAllFood();

        Task<ServiceResponse<IEnumerable<ResponseGetFood>>> GetAllFoodPagination(int indexPage);
        Task<ServiceResponse<IEnumerable<ResponseGetFood>>> GetAllFoodPaginationWithKeywords(int indexPage, string keywords);
        Task<ServiceResponse<IEnumerable<ResponseGetFood>>> GetAllFoodPaginationWithRestaurantType(int indexPage, string resType);

        Task<ServiceResponse<IEnumerable<ResponseGetFood>>> GetAllFoodInRestaurant(int resId);

        Task<ServiceResponse<ResponseGetFood>> GetFoodById(int foodId);

        Task<ServiceResponse<ResponseGetFood>> GetFoodInRestaurantById(RequestFoodContainRestaurant request);

        Task<ServiceResponse<string>> DeleteFood(RequestFoodContainRestaurant request);

        Task<ServiceResponse<ResponseGetFood>> UpdateFood(RequestUpdateFood request);
    }
}