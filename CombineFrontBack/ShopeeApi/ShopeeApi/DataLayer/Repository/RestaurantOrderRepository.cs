using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShopeeApi.Datas;
using ShopeeApi.Dtos.Request;
using ShopeeApi.IRepository;
using ShopeeApi.Models;

namespace ShopeeApi.Repository
{
    public class RestaurantOrderRepository : IRestaurantOrderRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public RestaurantOrderRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> DeleteRestaurant(int restaurantId, string userName, string foodTitle)
        {
            var findUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == userName);

            var findExistRecord = await _context.RestaurantOrders.Where(x => x.User == findUser
            && x.RestaurantId == restaurantId && x.FoodTitle == foodTitle).FirstOrDefaultAsync();

            if (findExistRecord == null)
            {
                return false;
            }

            _context.RestaurantOrders.Remove(findExistRecord);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ExistRecord(int restaurantId, string userName, string foodTitle)
        {
            var findUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == userName);

            if (findUser == null)
            {
                return false;
            }

            var findRecord = await _context.RestaurantOrders.Where(x => x.RestaurantId == restaurantId &&
                x.User == findUser && x.FoodTitle == foodTitle
            ).FirstOrDefaultAsync();

            if (findRecord == null)
            {
                return false;
            }

            return true;
        }

        public async Task<IEnumerable<RestaurantOrder>> GetAllRestaurantOrder(int restaurantId, string userName)
        {
            var findUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == userName);

            if (findUser == null)
            {
                return null;
            }

            return await _context.RestaurantOrders.Where(x => x.RestaurantId == restaurantId
                && x.User == findUser
            ).ToListAsync();
        }

        public async Task<RestaurantOrder> GetRestaurantOrderByFoodTitle(int restaurantId, string userName, string foodTitle)
        {
            var findUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == userName);

            var getRecord = await _context.RestaurantOrders.Where(
                x => x.RestaurantId == restaurantId
                && x.User == findUser
                && x.FoodTitle == foodTitle
                ).FirstOrDefaultAsync();

            if (getRecord == null)
            {
                return null;
            }

            return getRecord;
        }

        public async Task<RestaurantOrder> NewRestaurantOrder(RequestAddResOrder request)
        {
            var findUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == request.UserName);

            if (findUser == null)
            {
                return null;
            }

            var newOrder = _mapper.Map<RestaurantOrder>(request);

            newOrder.CreatedBy = request.UserName;
            newOrder.CreatedOn = DateTime.Now;
            newOrder.User = findUser;

            var createdOrder = await _context.RestaurantOrders.AddAsync(newOrder);
            await _context.SaveChangesAsync();

            return createdOrder.Entity;
        }

        public async Task<RestaurantOrder> UpdateRestaurantOrder(RequestUpdateResOrder request)
        {
            var findUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == request.UserName);

            var findOrderExist = await _context.RestaurantOrders.Where(x => x.User == findUser
            && x.RestaurantId == request.RestaurantId && x.FoodTitle == request.FoodTitle).FirstOrDefaultAsync()
                ;

            if (findOrderExist == null)
            {
                return null;
            }

            findOrderExist.UpdatedOn = DateTime.Now;
            findOrderExist.UpdatedBy = request.UserName;
            findOrderExist.CountFoodChoice = findOrderExist.CountFoodChoice + 1;

            var updatedValue = _context.RestaurantOrders.Update(findOrderExist);
            await _context.SaveChangesAsync();

            return updatedValue.Entity;
        }

        public async Task<RestaurantOrder> UpdateRestaurantOrderDecrease(RequestUpdateResOrder request)
        {
            var findUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == request.UserName);

            var findOrderExist = await _context.RestaurantOrders.Where(x => x.User == findUser
            && x.RestaurantId == request.RestaurantId && x.FoodTitle == request.FoodTitle).FirstOrDefaultAsync()
                ;

            if (findOrderExist == null)
            {
                return null;
            }

            findOrderExist.UpdatedOn = DateTime.Now;
            findOrderExist.UpdatedBy = request.UserName;
            findOrderExist.CountFoodChoice = findOrderExist.CountFoodChoice - 1;

            var updatedValue = _context.RestaurantOrders.Update(findOrderExist);
            await _context.SaveChangesAsync();

            return updatedValue.Entity;
        }
    }
}