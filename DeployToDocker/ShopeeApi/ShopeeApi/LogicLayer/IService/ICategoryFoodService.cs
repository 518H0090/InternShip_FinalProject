using ShopeeApi.Dtos.Request;
using ShopeeApi.Dtos.Response;
using ShopeeApi.Service;

namespace ShopeeApi.IService
{
    public interface ICategoryFoodService
    {
        Task<ServiceResponse<string>> ConnectFoodTag(int resId, RequestCategoryFood request);

        Task<ServiceResponse<string>> DeleteRelationFoodTag(int resId, RequestCategoryFood request);

        Task<ServiceResponse<IEnumerable<ResponseGetFoodTag>>> GetAllRelation();

        Task<ServiceResponse<IEnumerable<ResponseGetCategoryCombineFood>>> GetAllCategorywithRestaurantIdCombineFood(int resId);

        Task<ServiceResponse<ResponseGetCategoryCombineFood>> GetCategorywithRestaurantIdCombineFood(RequestCategoryCombineFood request);

        Task<ServiceResponse<IEnumerable<ResponseGetFoodCombineCategory>>> GetAllFoodwithRestaurantIdCombineCategory(int resId);

        Task<ServiceResponse<ResponseGetFoodCombineCategory>> GetFoodwithRestaurantIdCombineCategory(RequestFoodCombineCategory request);
    }
}