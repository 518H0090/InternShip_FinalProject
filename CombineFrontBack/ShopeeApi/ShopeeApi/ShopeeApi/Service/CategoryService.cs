using AutoMapper;
using LoggerService;
using ShopeeApi.Dtos;
using ShopeeApi.Models;
using ShopeeApi.Repository;

namespace ShopeeApi.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public CategoryService(ICategoryRepository repository, IMapper mapper, ILoggerManager logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ServiceResponse<ResponseGetCategory>> CreateCategory(RequestAddCategory request)
        {
            _logger.LogInfo("<START>Create Category</START>");

            var serviceResponse = new ServiceResponse<ResponseGetCategory>();

            var checkExistTagInRestaurant = await _repository.ExistsCategoryTag(request.RestaurantId, request.CategoryTag);
            var checkExistRestaurant = await _repository.ExistsRestaurantOrNot(request.RestaurantId);

            if (!checkExistRestaurant)
            {
                _logger.LogWarning("<WARN>Not Exist Restaurant</WARN>");
                serviceResponse.Success = false;
                serviceResponse.Message = "Not Exist Restaurant";
            }
            else if (checkExistTagInRestaurant)
            {
                _logger.LogWarning("<WARN>Exists Category Tag In Restaurant</WARN>");
                serviceResponse.Success = false;
                serviceResponse.Message = "Exists Category Tag In This Restaurant";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Create Category</PROCESS>");
                var newCategoryInRes = await _repository.CreateCategory(_mapper.Map<Category>(request));
                serviceResponse.Data = _mapper.Map<ResponseGetCategory>(newCategoryInRes);
            }

            _logger.LogInfo("<END>Create Category</END>");

            return serviceResponse;
        }

        public async Task<ServiceResponse<string>> DeleteCategory(RequestDeleteCategory request)
        {
            _logger.LogInfo("<START>Delete Category</START>");

            var response = new ServiceResponse<string>();

            var deleteCategory = await _repository.DeleteCategory(request.RestaurantId, request.CategoryId);

            if (!deleteCategory)
            {
                _logger.LogError("<ERROR>Delete Category</ERROR>");
                response.Success = false;
                response.Message = "Can't Delete Category";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Delete Category</PROCESS>");
                response.Data = "Delete Success";
            }

            _logger.LogInfo("<END>Delete Category</END>");

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetCategory>>> GetAllCategories(int ResId)
        {
            _logger.LogInfo("<START>Get All Categories</START>");

            var serviceResponse = new ServiceResponse<IEnumerable<ResponseGetCategory>>();

            var getAllCategory = await _repository.GetAllCategories(ResId);

            if (getAllCategory.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Can't Get All Categories</WARN>");
                serviceResponse.Success = false;
                serviceResponse.Message = "Not Found Any Category In This Restaurant";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Get All Categories</PROCESS>");
                serviceResponse.Data = getAllCategory.Select(c => _mapper.Map<ResponseGetCategory>(c)).ToList();
            }

            _logger.LogInfo("<END>Get All Categories</END>");

            return serviceResponse;
        }

        public async Task<ServiceResponse<ResponseGetCategory>> GetCategoryById(RequestCategoryById request)
        {
            _logger.LogInfo("<START>Get Category By Id</START>");

            var response = new ServiceResponse<ResponseGetCategory>();

            var CategoryWithId = await _repository.GetCategoryById(request.RestaurantId, request.CategoryId);

            if (CategoryWithId == null)
            {
                _logger.LogWarning("<WARN>Can't Get Category By Id</WARN>");
                response.Success = false;
                response.Message = "Not Found Any Category In This Restaurant";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Get Category By Id</PROCESS>");
                response.Data = _mapper.Map<ResponseGetCategory>(CategoryWithId);
            }

            _logger.LogInfo("<END>Get Category By Id</END>");

            return response;
        }

        public async Task<ServiceResponse<ResponseGetCategory>> GetCategoryByTag(RequestCategoryByTag request)
        {
            _logger.LogInfo("<START>Get Category By Tag</START>");

            var response = new ServiceResponse<ResponseGetCategory>();

            var CategoryWithTag = await _repository.GetCategoryByTag(request.RestaurantId, request.CategoryTag);

            if (CategoryWithTag == null)
            {
                _logger.LogWarning("<WARN>Can't Get Category By Tag</WARN>");
                response.Success = false;
                response.Message = "Not Found Any Category In This Restaurant";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Get Category By Tag</PROCESS>");
                response.Data = _mapper.Map<ResponseGetCategory>(CategoryWithTag);
            }

            _logger.LogInfo("<END>Get Category By Tag</END>");

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetCategory>>> GetFullCategories()
        {
            _logger.LogInfo("<START>Get Full Categories</START>");

            var response = new ServiceResponse<IEnumerable<ResponseGetCategory>>();

            var getFullCatgories = await _repository.GetFullCategories();

            if (getFullCatgories.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Can't Get Full Categories</WARN>");
                response.Success = false;
                response.Message = "Not Found Any Category";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Get Full Categories</PROCESS>");
                response.Data = getFullCatgories.Select(x => _mapper.Map<ResponseGetCategory>(x));
            }

            _logger.LogInfo("<END>Get Full Categories</END>");

            return response;
        }

        public async Task<ServiceResponse<ResponseGetCategory>> UpdateCategory(RequestEditCategory request)
        {
            _logger.LogInfo("<START>Update Category</START>");

            var response = new ServiceResponse<ResponseGetCategory>();

            var updateCategory = await _repository.UpdateCategory(_mapper.Map<Category>(request));

            if (updateCategory == null)
            {
                _logger.LogError("<ERROR>Can't Update Category</ERROR>");
                response.Success = false;
                response.Message = "Can't Update Category";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Update Category</PROCESS>");
                response.Data = _mapper.Map<ResponseGetCategory>(updateCategory);
            }

            _logger.LogInfo("<END>Update Category</END>");

            return response;
        }
    }
}