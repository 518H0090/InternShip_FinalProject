using ShopeeApi.Models;

namespace ShopeeApi.Repository
{
    public interface IBillRepository
    {
        Task<Bill> CreateNewBill(Bill request);
        
        Task<bool> ExistsUserName(string username);

        Task<IEnumerable<Bill>> GetAllBill();

        Task<IEnumerable<Bill>> GetAllBillFollowUsername(string username);

    }
}
