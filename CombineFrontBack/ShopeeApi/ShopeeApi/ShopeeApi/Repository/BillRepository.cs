using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using ShopeeApi.Datas;
using ShopeeApi.Models;

namespace ShopeeApi.Repository
{
    public class BillRepository : IBillRepository
    {
        private readonly DataContext _context;

        public BillRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Bill> CreateNewBill(Bill request)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var findUser = await _context.Users.Where(x => x.UserName == request.UseName)
                 .FirstOrDefaultAsync();

                    if (findUser == null)
                    {
                        throw new Exception("Can't Find User");
                    }

                    var listOrderFollowUser = await _context.SelectFoodRecords.Where(x => x.User == findUser).ToListAsync();

                    if (listOrderFollowUser == null)
                    {
                        throw new Exception("Can't Find Any List Order");
                    }

                    request.User = findUser;

                    var newBill = await _context.Bills.AddAsync(request);

                    _context.SelectFoodRecords.RemoveRange(listOrderFollowUser);
                    
                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();

                    return newBill.Entity;
                }

                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
           
        }

        public async Task<bool> ExistsUserName(string username)
        {
            var findUser = await _context.Users.AnyAsync(u => u.UserName == username);

            return findUser;
        }

        public async Task<IEnumerable<Bill>> GetAllBill()
        {
            return await _context.Bills.ToListAsync();
        }

        public async Task<IEnumerable<Bill>> GetAllBillFollowUsername(string username)
        {
            IEnumerable<Bill> listBill;

            var findUser = await _context.Users.Where(x => x.UserName == username)
               .FirstOrDefaultAsync();

            if (findUser == null)
            {
                listBill = new List<Bill>();
            }

            else
            {
                listBill = await _context.Bills.Where(x => x.User == findUser).ToListAsync();
            }

            return listBill;
        }
    }
}
