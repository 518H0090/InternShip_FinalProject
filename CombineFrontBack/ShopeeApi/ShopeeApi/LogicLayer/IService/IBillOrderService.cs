using ShopeeApi.Dtos.Request;
using ShopeeApi.Dtos.Response;
using ShopeeApi.Service;

namespace ShopeeApi.IService
{
    public interface IBillOrderService
    {
        Task<ServiceResponse<ResponseBillOrder>> CreateBillOrder(RequestAddBillOrder request);

        Task<ServiceResponse<IEnumerable<ResponseBillOrder>>> GetAllBillOrder(string username);

        Task<ServiceResponse<ResponseBillOrder>> CreateBillAllOrderProcess(string username);

        Task<ServiceResponse<IEnumerable<ResponseBillOrder>>> GetAllBillOrderIncludeOrder(string username);
    }
}