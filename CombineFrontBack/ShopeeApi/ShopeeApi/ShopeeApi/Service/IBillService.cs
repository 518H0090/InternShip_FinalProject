using ShopeeApi.Dtos;
using ShopeeApi.Repository;

namespace ShopeeApi.Service
{
    public interface IBillService 
    {
        Task<ServiceResponse<ResponseGetBill>> CreateNewBill(RequestAddBill request);

        Task<ServiceResponse<IEnumerable<ResponseGetBill>>> GetAllBill();

        Task<ServiceResponse<IEnumerable<ResponseGetBill>>> GetAllBillFollowUsername(string username);
    }
}
