using ShopeeApi.Models;

namespace ShopeeApi.Repository
{
    public interface IBillOrderRepository
    {
        Task<BillOrder> CreateBillOrder(BillOrder request);

        Task<IEnumerable<BillOrder>> GetAllBillOrder(string username);
    }
}
