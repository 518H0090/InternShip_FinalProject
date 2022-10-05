using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShopeeApi.Datas;
using ShopeeApi.Dtos;
using ShopeeApi.Models;

namespace ShopeeApi.Repository
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public RestaurantRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Restaurant> CreateRestaurant(Restaurant request)
        {
            var newCharacter = await _context.Restaurants.AddAsync(request);
            await _context.SaveChangesAsync();

            return newCharacter.Entity;
        }

        public async Task<bool> DeleteRestaurant(int ResId)
        {
            var findCharacter = await _context.Restaurants.FindAsync(ResId);

            if (findCharacter == null)
            {
                return false;
            }

            _context.Restaurants.Remove(findCharacter);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ExistRestaurant(string RsTitle)
        {
            var checkRes = await _context.Restaurants.FirstOrDefaultAsync(u => u.RsTitle == RsTitle);

            if (checkRes != null)
            {
                return true;
            } 
            
            else
            {
                return false;
            }
        }

        public async Task<IEnumerable<Restaurant>> GetAllRestaurant()
        {
            return await _context.Restaurants.ToListAsync();
        }

        public async Task<Restaurant> GetRestaurantById(int ResId)
        {
            return await _context.Restaurants.FirstAsync(u => u.RsId == ResId);
        }

        public async Task<Restaurant> UpdateRestaurant(int ResId, Restaurant request)
        {
            var findRes = await _context.Restaurants.FindAsync(ResId);

            if (findRes == null)
            {
                return null;
            }

            findRes.RsTitle = request.RsTitle;
            findRes.RsProvince = request.RsProvince;
            findRes.RsAddress = request.RsAddress;
            findRes.RsType = request.RsType;
            findRes.RsImageUrl = request.RsImageUrl;
            findRes.RsStar = request.RsStar;
            findRes.RsReviews = request.RsReviews;
            findRes.RsOpenTime = request.RsOpenTime;
            findRes.RsPrinceRange = request.RsPrinceRange;
            findRes.RsRefeLike = request.RsRefeLike;
         
            var updatedRes = _context.Restaurants.Update(findRes);
            await _context.SaveChangesAsync();

            return updatedRes.Entity;
        }
    }
}
