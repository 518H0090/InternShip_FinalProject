using AutoMapper;
using LoggerService;
using ShopeeApi.Dtos.Request;
using ShopeeApi.Dtos.Response;
using ShopeeApi.IRepository;
using ShopeeApi.IService;
using ShopeeApi.Models;

namespace ShopeeApi.Service
{
    public class CategoryFoodService : ICategoryFoodService
    {
        private readonly ICategoryFoodRepository _repository;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public CategoryFoodService(ICategoryFoodRepository repository, IMapper mapper, ILoggerManager logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ServiceResponse<string>> ConnectFoodTag(int resId, RequestCategoryFood request)
        {
            _logger.LogInfo("<START>Connect Food Tag</START>");

            var response = new ServiceResponse<string>();

            if (await _repository.ExistsRelationFoodTag(resId, _mapper.Map<RelationCategoryFood>(request)))
            {
                _logger.LogError("<ERROR>Can't Connect Food Tag</ERROR>");
                response.Success = false;
                response.Message = "Can't Create New Relationship";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Connect Food Tag</PROCESS>");
                await _repository.ConnectFoodTag(_mapper.Map<RelationCategoryFood>(request));
                response.Data = "Create New Relationship";
            }

            _logger.LogInfo("<END>Connect Food Tag</END>");

            return response;
        }

        public async Task<ServiceResponse<string>> DeleteRelationFoodTag(int resId, RequestCategoryFood request)
        {
            _logger.LogInfo("<START>Delete Relation Food Tag</START>");

            var response = new ServiceResponse<string>();

            if (await _repository.ExistsRelationFoodTag(resId, _mapper.Map<RelationCategoryFood>(request)))
            {
                var deleteRelation = await _repository.DeleteRelationFoodTag(_mapper.Map<RelationCategoryFood>(request));

                if (deleteRelation == false)
                {
                    _logger.LogError("<ERROR>Can't Delete Relation Food Tag</ERROR>");
                    response.Success = false;
                    response.Message = "Can't Delete Relationship";
                }

                _logger.LogInfo("<PROCESS>Delete Relation Food Tag</PROCESS>");
                response.Data = "Delete Succesfully";
            }
            else
            {
                _logger.LogWarning("<WARN>Can't Find Value Use For Delete</WARN>");
                response.Success = false;
                response.Message = "Can't Find Value Use For Delete";
            }

            _logger.LogInfo("<END>Delete Relation Food Tag</END>");

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetCategoryCombineFood>>> GetAllCategorywithRestaurantIdCombineFood(int resId)
        {
            _logger.LogInfo("<START>Get All Category with Restaurant Id Combine Food</START>");

            var response = new ServiceResponse<IEnumerable<ResponseGetCategoryCombineFood>>();

            var getCategoryCombineFood = await _repository.GetAllCategorywithRestaurantIdCombineFood(resId);

            if (getCategoryCombineFood.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Can't Get All Category with Restaurant Id Combine Food</WARN>");
                response.Success = false;
                response.Message = "Not Found Any Value";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Get All Category with Restaurant Id Combine Food</PROCESS>");
                response.Data = getCategoryCombineFood.Select(x =>
                _mapper.Map<ResponseGetCategoryCombineFood>(x));
            }

            _logger.LogInfo("<END>Get All Category with Restaurant Id Combine Food</END>");

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetFoodCombineCategory>>> GetAllFoodwithRestaurantIdCombineCategory(int resId)
        {
            _logger.LogInfo("<START>Get All Food with Restaurant Id Combine Category</START>");

            var response = new ServiceResponse<IEnumerable<ResponseGetFoodCombineCategory>>();

            var getFoodCombineCategory = await _repository.GetAllFoodwithRestaurantIdCombineCategory(resId);

            if (getFoodCombineCategory.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Can't Get All Category with Restaurant Id Combine Food</WARN>");
                response.Success = false;
                response.Message = "Not Found Any Value";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Get All Food with Restaurant Id Combine Category</PROCESS>");
                response.Data = getFoodCombineCategory.Select(x =>
                _mapper.Map<ResponseGetFoodCombineCategory>(x));
            }

            _logger.LogInfo("<END>Get All Food with Restaurant Id Combine Category</END>");

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetFoodTag>>> GetAllRelation()
        {
            _logger.LogInfo("<START>Get All Relation</START>");

            var response = new ServiceResponse<IEnumerable<ResponseGetFoodTag>>();

            var getAllRelation = await _repository.GetAllRelation();

            if (getAllRelation.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Can't Get All Relation</WARN>");
                response.Message = "Can't Find Any Value";
                response.Success = false;
            }
            else
            {
                _logger.LogInfo("<PROCESS>Get All Relation</PROCESS>");
                response.Data = getAllRelation.Select(x => _mapper.Map<ResponseGetFoodTag>(x));
            }

            _logger.LogInfo("<END>Get All Relation</END>");

            return response;
        }

        public async Task<ServiceResponse<ResponseGetCategoryCombineFood>> GetCategorywithRestaurantIdCombineFood(RequestCategoryCombineFood request)
        {
            _logger.LogInfo("<START>Get Category with Restaurant Id Combine Food</START>");

            var response = new ServiceResponse<ResponseGetCategoryCombineFood>();

            var getFoodCombineCategory = await _repository.GetCategorywithRestaurantIdCombineFood(request.RestaurantId, request.CategoryId);

            if (getFoodCombineCategory == null)
            {
                _logger.LogWarning("<WARN>Can't Get Category with Restaurant Id Combine Food</WARN>");
                response.Success = false;
                response.Message = "Not Found Value";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Get Category with Restaurant Id Combine Food</PROCESS>");
                response.Data = _mapper.Map<ResponseGetCategoryCombineFood>(getFoodCombineCategory);
            }

            _logger.LogInfo("<END>Get Category with Restaurant Id Combine Food</END>");

            return response;
        }

        public async Task<ServiceResponse<ResponseGetFoodCombineCategory>> GetFoodwithRestaurantIdCombineCategory(RequestFoodCombineCategory request)
        {
            _logger.LogInfo("<START>Get Food with Restaurant Id Combine Category</START>");

            var response = new ServiceResponse<ResponseGetFoodCombineCategory>();

            var getFoodCombineCategory = await _repository.GetFoodwithRestaurantIdCombineCategory(request.RestaurantId, request.FoodId);

            if (getFoodCombineCategory == null)
            {
                _logger.LogWarning("<WARN>Can't Get Food with Restaurant Id Combine Category</WARN>");
                response.Success = false;
                response.Message = "Not Found Value";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Get Food with Restaurant Id Combine Category</PROCESS>");
                response.Data = _mapper.Map<ResponseGetFoodCombineCategory>(getFoodCombineCategory);
            }

            _logger.LogInfo("<END>Get Food with Restaurant Id Combine Category</END>");

            return response;
        }
    }
}