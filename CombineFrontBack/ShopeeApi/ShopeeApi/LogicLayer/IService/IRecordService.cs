using ShopeeApi.Dtos.Request;
using ShopeeApi.Dtos.Response;
using ShopeeApi.Service;

namespace ShopeeApi.IService
{
    public interface IRecordService
    {
        Task<ServiceResponse<ResponseGetFoodRecord>> NewRecord(RequestAddFoodRecord request, string username);

        Task<ServiceResponse<IEnumerable<ResponseGetFoodRecord>>> GetAllRecordFollowUsername(string username);

        Task<ServiceResponse<IEnumerable<ResponseGetFoodRecord>>> GetTop6RecordFollowUsername(string username);

        Task<ServiceResponse<string>> DeleteRecord(RequestDeleteFoodRecord request);
    }
}
