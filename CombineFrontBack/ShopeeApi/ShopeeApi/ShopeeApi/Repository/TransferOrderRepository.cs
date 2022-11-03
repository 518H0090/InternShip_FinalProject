using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShopeeApi.Datas;
using ShopeeApi.Models;

namespace ShopeeApi.Repository
{
    public class TransferOrderRepository : ITransferOrderRepository
    {
        private readonly DataContext _context;

        public TransferOrderRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<TransferOrder> CreateTransferOrder(TransferOrder request, int restaurantId)
        {
            
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var findUser = await _context.Users.Where(x => x.UserName == request.Username).FirstAsync();

                    request.User = findUser;
                    request.CreatedBy = request.Username;
                    request.TotalMoney = request.TempMoney;

                    request.TotalMoney = request.TempMoney - (int)request.Promotion;

                    if (request.TotalMoney <= 0)
                    {
                        request.TotalMoney = 0;
                        request.ORDERSTATUS = ORDERSTATUS.FINISH;
                    }

                    var newTransferOrder = await _context.TransferOrders.AddAsync(request);
                    await _context.SaveChangesAsync();

                    var getAllRestaurantOrder = await _context.RestaurantOrders.Where(x => x.UserId == 
                    newTransferOrder.Entity.UserId && x.RestaurantId == restaurantId).ToListAsync();

                    _context.RestaurantOrders.RemoveRange(getAllRestaurantOrder);
                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();

                    return newTransferOrder.Entity;
                }

                catch(Exception e)
                {
                    await transaction.RollbackAsync();
                    Console.WriteLine("Can't Create Order" + e.Message);
                    return null;
                }
            }

        }

        public async Task<bool> DeleteTransferOrder(TransferOrder request)
        {

            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var findTransferOrder = await _context.TransferOrders.Where(x => x.Username == request.Username
                       && x.OrderId == request.OrderId
                       ).FirstAsync();

                    if (findTransferOrder.ORDERSTATUS == ORDERSTATUS.PROCESS)
                    {
                        throw new Exception("Not Permited Delete");
                    }

                    _context.TransferOrders.Remove(findTransferOrder);
                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();

                    return true;
                }
                
                catch(Exception e)
                {
                    await transaction.RollbackAsync();
                    Console.WriteLine($"<ERROR> {e.Message} </ERROR>");
                    return false;
                }
            }

        }

        public async Task<bool> ExistUser(string username)
        {
            return await _context.Users.AnyAsync(x => x.UserName == username);
        }

        public async Task<IEnumerable<TransferOrder>> GetAllTransferOrder(string username)
        {
            return await _context.TransferOrders.Where(x => x.Username == username).OrderBy(x => x.CreatedOn).ToListAsync();
        }

        public async Task<bool> isTransferOrderPayment(TransferOrder request)
        {
            var findTransferOrder = await _context.TransferOrders.Where(x => x.Username == request.Username
            && x.OrderId == request.OrderId
            ).FirstOrDefaultAsync();

            if (findTransferOrder == null || findTransferOrder.ORDERSTATUS != ORDERSTATUS.FINISH)
            {
                return false;
            }

            return true;
        }
        
    }
}
