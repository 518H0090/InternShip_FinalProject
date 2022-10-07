using AutoMapper;
using ShopeeApi.Repository;

namespace ShopeeApi.Service
{
    public class CategoryFoodService : ICategoryFoodService
    {
        private readonly ICategoryFoodRepository _repository;
        private readonly IMapper _mapper;

        public CategoryFoodService(ICategoryFoodRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}
