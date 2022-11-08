using ShopeeApi.Models;

namespace ShopeeApi.IRepository
{
    public interface IBillOrderRepository
    {
        Task<BillOrder> CreateBillOrder(BillOrder request);

        Task<BillOrder> CreateBillAllOrderProcess(string username);

        Task<IEnumerable<BillOrder>> GetAllBillOrder(string username);

        Task<IEnumerable<BillOrder>> GetAllBillOrderIncludeOrder(string username);
    }
}
