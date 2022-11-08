using Microsoft.EntityFrameworkCore;
using ShopeeApi.Datas;
using ShopeeApi.IRepository;
using ShopeeApi.Models;

namespace ShopeeApi.Repository
{
    public class RecordRepository : IRecordRepository
    {
        private readonly DataContext _context;

        public RecordRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<int> CountNumberRecord(string username)
        {
            var findUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == username);

            int countRecord = 0;

            if (findUser == null)
            {
                countRecord = 0;
            }

            var listRecordFoodFollowUser = await _context.SelectFoodRecords
                .Where(x => x.User == findUser).ToListAsync();

            listRecordFoodFollowUser.ForEach(element =>
            {
                countRecord++;
            });

            return countRecord;
        }

        public async Task<bool> DeleteRecord(int recordId, string username)
        {
            var findUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == username);

            var findRecord = await _context.SelectFoodRecords
                .FirstOrDefaultAsync(x => x.RecordId == recordId);

            if (findRecord == null || findUser == null)
            {
                return false;
            }

            _context.SelectFoodRecords.Remove(findRecord);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<SelectFoodRecord>> GetAllRecordFollowUsername(string username)
        {
            var findUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == username);

            if (findUser == null)
            {
                return null;
            }

            return await _context.SelectFoodRecords
                .Where(x => x.User == findUser).ToListAsync();
        }

        public async Task<IEnumerable<SelectFoodRecord>> GetTop6RecordFollowUsername(string username)
        {
            var findUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == username);

            if (findUser == null)
            {
                return null;
            }

            return await _context.SelectFoodRecords
                .Where(x => x.User == findUser).Take(6).ToListAsync();
        }

        public async Task<SelectFoodRecord> NewRecord(SelectFoodRecord request, string username)
        {
            var findUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == username);

            if (findUser == null)
            {
                return null;
            }


            request.User = findUser;

            var newRecord = await _context.SelectFoodRecords.AddAsync(request);
            await _context.SaveChangesAsync();

            return newRecord.Entity;
        }

        public async Task<float> TotalPriceRecord(string username)
        {
            var findUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == username);

            float totalCost = 0;

            if (findUser == null)
            {
                totalCost = 0;
            }

            var listRecordFoodFollowUser = await _context.SelectFoodRecords
                .Where(x => x.User == findUser).ToListAsync();

            listRecordFoodFollowUser.ForEach(element =>
            {
                totalCost += element.FoodPrice;
            });

            return totalCost;
        }
    }
}
