using ShopeeApi.Dtos.Request;
using ShopeeApi.Dtos.Response;
using ShopeeApi.Service;

namespace ShopeeApi.IService
{
    public interface ITransferOrderService
    {
        Task<ServiceResponse<ResponseTransferOrder>> CreateTransferOrder(RequestAddTransferOrder request);

        Task<ServiceResponse<IEnumerable<ResponseTransferOrder>>> GetAllTransferOrder(string username);

        Task<ServiceResponse<IEnumerable<ResponseTransferOrder>>> GetAllTransferOrderProcess(string username);

        Task<ServiceResponse<string>> DeleteTransferOrder(RequestDeleteTransferOrder request);
    }
}