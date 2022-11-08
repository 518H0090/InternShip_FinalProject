using ShopeeApi.Dtos.Request;
using ShopeeApi.Dtos.Response;
using ShopeeApi.Service;

namespace ShopeeApi.IService
{
    public interface IBillService
    {
        Task<ServiceResponse<ResponseGetBill>> CreateNewBill(RequestAddBill request);

        Task<ServiceResponse<IEnumerable<ResponseGetBill>>> GetAllBill();

        Task<ServiceResponse<IEnumerable<ResponseGetBill>>> GetAllBillFollowUsername(string username);
    }
}
