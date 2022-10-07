using ShopeeApi.Datas;

namespace ShopeeApi.Repository
{
    public class CategoryFoodRepository : ICategoryFoodRepository
    {
        private readonly DataContext _context;

        public CategoryFoodRepository(DataContext context)
        {
            _context = context;
        }
    }
}
