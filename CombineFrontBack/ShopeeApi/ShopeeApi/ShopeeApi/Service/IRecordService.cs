using ShopeeApi.Dtos;
using ShopeeApi.Repository;

namespace ShopeeApi.Service
{
    public interface IRecordService
    {
        Task<ServiceResponse<ResponseGetFoodRecord>> NewRecord(RequestAddFoodRecord request, string username);

        Task<ServiceResponse<IEnumerable<ResponseGetFoodRecord>>> GetAllRecordFollowUsername(string username);

        Task<ServiceResponse<IEnumerable<ResponseGetFoodRecord>>> GetTop6RecordFollowUsername(string username);

        Task<ServiceResponse<string>> DeleteRecord(RequestDeleteFoodRecord request);
    }
}
