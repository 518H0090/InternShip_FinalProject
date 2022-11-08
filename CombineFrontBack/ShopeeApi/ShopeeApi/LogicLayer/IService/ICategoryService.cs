using ShopeeApi.Dtos.Request;
using ShopeeApi.Dtos.Response;
using ShopeeApi.Service;

namespace ShopeeApi.IService
{
    public interface ICategoryService
    {
        Task<ServiceResponse<ResponseGetCategory>> CreateCategory(RequestAddCategory request);

        Task<ServiceResponse<IEnumerable<ResponseGetCategory>>> GetFullCategories();

        Task<ServiceResponse<IEnumerable<ResponseGetCategory>>> GetAllCategories(int ResId);

        Task<ServiceResponse<ResponseGetCategory>> GetCategoryById(RequestCategoryById request);

        Task<ServiceResponse<ResponseGetCategory>> GetCategoryByTag(RequestCategoryByTag request);

        Task<ServiceResponse<string>> DeleteCategory(RequestDeleteCategory request);

        Task<ServiceResponse<ResponseGetCategory>> UpdateCategory(RequestEditCategory request);
    }
}