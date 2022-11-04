using ShopeeApi.Dtos;
using ShopeeApi.Repository;

namespace ShopeeApi.Service
{
    public interface IBillOrderService
    {
        Task<ServiceResponse<ResponseBillOrder>> CreateBillOrder(RequestAddBillOrder request);

        Task<ServiceResponse<IEnumerable<ResponseBillOrder>>> GetAllBillOrder(string username);

        Task<ServiceResponse<ResponseBillOrder>> CreateBillAllOrderProcess(string username);

        Task<ServiceResponse<IEnumerable<ResponseBillOrder>>> GetAllBillOrderIncludeOrder(string username);
    }
}
