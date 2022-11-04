using Microsoft.EntityFrameworkCore;
using ShopeeApi.Datas;
using ShopeeApi.Models;

namespace ShopeeApi.Repository
{
    public class BillOrderRepository : IBillOrderRepository
    {
        private readonly DataContext _context;

        public BillOrderRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<BillOrder> CreateBillAllOrderProcess(string username)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    int totalMoney = 0;

                    var findUser = await _context.Users.FirstAsync(x => x.UserName == username);

                    var allTransferOrderProcess = await _context.TransferOrders.Where(x => x.Username == username
                    && x.ORDERSTATUS == ORDERSTATUS.PROCESS
                    ).ToListAsync();

                    List<TransferOrder> updateListTransfer = new List<TransferOrder>();

                    allTransferOrderProcess.ForEach(element =>
                    {
                        element.ORDERSTATUS = ORDERSTATUS.FINISH;

                        updateListTransfer.Add(element);

                        totalMoney += element.TotalMoney;
                    });

                    if (totalMoney == 0)
                    {
                        throw new Exception();
                    }

                    BillOrder billOrder = new BillOrder
                    {
                        CreatedBy = username,
                        TotalMoney = totalMoney,
                        CreatedOn = DateTime.Now,
                        User = findUser,
                        TransferOrders = updateListTransfer
                    };

                    _context.TransferOrders.UpdateRange(updateListTransfer);
                    await _context.SaveChangesAsync();

                    var newBillOrder = await _context.BillOrders.AddAsync(billOrder);
                    await _context.SaveChangesAsync();

                    if (newBillOrder == null)
                    {
                        throw new Exception();
                    }

                  

                    await transaction.CommitAsync();

                    return newBillOrder.Entity;
                }

                catch(Exception e)
                {
                    await transaction.RollbackAsync();
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }

        public async Task<BillOrder> CreateBillOrder(BillOrder request)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var findUser = await _context.Users.FirstAsync(x => x.UserName == request.CreatedBy);

                    request.User = findUser;

                    var newBill = await _context.BillOrders.AddAsync(request);
                    await _context.SaveChangesAsync();

                    await transaction.CommitAsync();

                    return newBill.Entity;
                }

                catch(Exception e)
                {
                    await transaction.RollbackAsync();
                    Console.WriteLine($"<ERROR>{e.Message}</ERROR>");
                    return null;
                }
            }
        }

        public async Task<IEnumerable<BillOrder>> GetAllBillOrder(string username)
        {
            var findUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == username);

            if (findUser == null)
            {
                return null;
            }

            return await _context.BillOrders.Where(x => x.User == findUser).ToListAsync();
        }

        public async Task<IEnumerable<BillOrder>> GetAllBillOrderIncludeOrder(string username)
        {
            var findUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == username);

            if (findUser == null)
            {
                return null;
            }

            return await _context.BillOrders.Where(x => x.User == findUser).Include(x => x.TransferOrders).ToListAsync();
        }
    }
}
