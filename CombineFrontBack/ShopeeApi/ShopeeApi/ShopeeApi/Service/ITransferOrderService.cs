using ShopeeApi.Dtos;
using ShopeeApi.Repository;

namespace ShopeeApi.Service
{
    public interface ITransferOrderService
    {
        Task<ServiceResponse<ResponseTransferOrder>> CreateTransferOrder(RequestAddTransferOrder request);

        Task<ServiceResponse<IEnumerable<ResponseTransferOrder>>> GetAllTransferOrder(string username);

        Task<ServiceResponse<IEnumerable<ResponseTransferOrder>>> GetAllTransferOrderProcess(string username);

        Task<ServiceResponse<string>> DeleteTransferOrder(RequestDeleteTransferOrder request);

    }
}
