using AutoMapper;
using LoggerService;
using ShopeeApi.Dtos;
using ShopeeApi.Models;
using ShopeeApi.Repository;

namespace ShopeeApi.Service
{
    public class FoodService : IFoodService
    {
        private readonly IMapper _mapper;
        private readonly IFoodRepository _repository;
        private readonly ILoggerManager _logger;

        public FoodService(IMapper mapper, IFoodRepository repository, ILoggerManager logger)
        {
            _mapper = mapper;
            _repository = repository;
            _logger = logger;
        }

        public async Task<ServiceResponse<ResponseGetFood>> CreateFood(RequestAddFood request)
        {
            _logger.LogInfo("<START>Create Food</START>");

            var serviceResponse = new ServiceResponse<ResponseGetFood>();

            if ((await _repository.ExistsRestaurant(_mapper.Map<Food>(request))) == false)
            {
                _logger.LogWarning("<WARN>Not Exist Restaurant</WARN>");
                serviceResponse.Success = false;
                serviceResponse.Message = "Not Exist Restaurant";
            }
            else
            {
                try
                {
                    _logger.LogInfo("<PROCESS>Create Food</PROCESS>");
                    var newFood = await _repository.CreateFood(_mapper.Map<Food>(request));

                    serviceResponse.Data = _mapper.Map<ResponseGetFood>(newFood);
                }
                catch (Exception ex)
                {
                    _logger.LogError("<ERROR>Can't Create Food In Restaurant</ERROR>");
                    serviceResponse.Success = false;
                    serviceResponse.Message = $"Exists Food In this Restaurant + {ex.Message}";
                }
            }

            _logger.LogInfo("<END>Create Food</END>");

            return serviceResponse;
        }

        public async Task<ServiceResponse<string>> DeleteFood(RequestFoodContainRestaurant request)
        {
            _logger.LogInfo("<START>Delete Food</START>");

            var response = new ServiceResponse<string>();

            var deleteFood = await _repository.DeleteFood(_mapper.Map<Food>(request));

            if (!deleteFood)
            {
                _logger.LogError("<ERROR>Can't Delete Food</ERROR>");
                response.Success = false;
                response.Message = "Can't Delete Food";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Delete Food</PROCESS>");
                response.Data = "Delete Success";
            }

            _logger.LogInfo("<END>Delete Food</END>");

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetFood>>> GetAllFood()
        {
            _logger.LogInfo("<START>Get All Food</START>");

            var response = new ServiceResponse<IEnumerable<ResponseGetFood>>();

            var getAllWithoutRestaurant = await _repository.GetAllFood();

            if (getAllWithoutRestaurant.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Can't Find Any Food</WARN>");
                response.Success = false;
                response.Message = "Not Found Any Value";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Get All Food</PROCESS>");
                response.Data = getAllWithoutRestaurant.Select(x => _mapper.Map<ResponseGetFood>(x));
            }

            _logger.LogInfo("<END>Get All Food</END>");

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetFood>>> GetAllFoodInRestaurant(int resId)
        {
            _logger.LogInfo("<START>Get All Food In Restaurant</START>");

            var response = new ServiceResponse<IEnumerable<ResponseGetFood>>();

            var queryForFood = new Food
            {
                RestaurantId = resId
            };

            var getAllWithRestaurant = await _repository.GetAllFoodInRestaurant(queryForFood);

            if (getAllWithRestaurant.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Can't Get All Food</WARN>");
                response.Success = false;
                response.Message = "Not Found Any Value";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Get All Food In Restaurant</PROCESS>");
                response.Data = getAllWithRestaurant.Select(x => _mapper.Map<ResponseGetFood>(x));
            }

            _logger.LogInfo("<END>Get All Food In Restaurant</END>");

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetFood>>> GetAllFoodPagination(int indexPage)
        {
            _logger.LogInfo("<START>Get All Food Pagination</START>");

            var response = new ServiceResponse<IEnumerable<ResponseGetFood>>();

            var getAllWithoutRestaurant = await _repository.GetAllFoodPagination(indexPage);

            if (getAllWithoutRestaurant.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Can't Get All Food In Restaurant</WARN>");
                response.Success = false;
                response.Message = "Not Found Any Value Or Over Range";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Get All Food Pagination</PROCESS>");
                response.Data = getAllWithoutRestaurant.Select(x => _mapper.Map<ResponseGetFood>(x));
            }

            _logger.LogInfo("<END>Get All Food Pagination</END>");

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetFood>>> GetAllFoodPaginationWithKeywords(int indexPage, string keywords)
        {
            _logger.LogInfo("<START>Get All Food Pagination With Keywords</START>");

            var response = new ServiceResponse<IEnumerable<ResponseGetFood>>();

            var getAllWithoutRestaurant = await _repository.GetAllFoodPaginationWithKeywords(indexPage, keywords);

            if (getAllWithoutRestaurant.ToList().Count <= 0)
            {
                _logger.LogWarning("<ERROR>Get All Food Pagination With Keywords</ERROR>");
                response.Success = false;
                response.Message = "Not Found Any Value Or Over Range";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Get All Food Pagination With Keywords</PROCESS>");
                response.Data = getAllWithoutRestaurant.Select(x => _mapper.Map<ResponseGetFood>(x));
            }
            _logger.LogInfo("<END>Get All Food Pagination With Keywords</END>");
            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetFood>>> GetAllFoodPaginationWithRestaurantType(int indexPage, string resType)
        {
            _logger.LogInfo("<START>Get All Food Pagination With Restaurant Type</START>");

            var response = new ServiceResponse<IEnumerable<ResponseGetFood>>();

            var getAllWitRestaurantType = await _repository.GetAllFoodPaginationWithRestaurantType(indexPage, resType);

            if (getAllWitRestaurantType == null || getAllWitRestaurantType.ToList().Count <= 0 )
            {
                _logger.LogWarning("<WARN>Can't Get All Food Pagination With Restaurant Type</WARN>");
                response.Success = false;
                response.Message = "Not Found Any Value Or Over Range";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Get All Food Pagination With Restaurant Type</PROCESS>");
                response.Data = getAllWitRestaurantType.Select(x => _mapper.Map<ResponseGetFood>(x));
            }

            _logger.LogInfo("<END>Get All Food Pagination With Restaurant Type</END>");

            return response;
        }

        public async Task<ServiceResponse<ResponseGetFood>> GetFoodById(int foodId)
        {
            _logger.LogInfo("<START>Get Food By Id</START>");

            var response = new ServiceResponse<ResponseGetFood>();

            Food queryFood = new Food
            {
                FoodId = foodId
            };

            var getFoodById = await _repository.GetFoodById(queryFood);

            if (getFoodById == null)
            {
                _logger.LogWarning("<WARN>Can't Get Food By Id</WARN>");
                response.Success = false;
                response.Message = "Not Found Value";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Get Food By Id</PROCESS>");
                response.Data = _mapper.Map<ResponseGetFood>(getFoodById);
            }

            _logger.LogInfo("<END>Get Food By Id</END>");

            return response;
        }

        public async Task<ServiceResponse<ResponseGetFood>> GetFoodInRestaurantById(RequestFoodContainRestaurant request)
        {
            _logger.LogInfo("<START>Get Food In Restaurant By Id</START>");

            var response = new ServiceResponse<ResponseGetFood>();

            Food queryFood = new Food
            {
                FoodId = request.FoodId,
                RestaurantId = request.RestaurantId
            };

            var getFoodById = await _repository.GetFoodInRestaurantById(queryFood);

            if (getFoodById == null)
            {
                _logger.LogWarning("<WARN>Can't Get Food In Restaurant By Id</WARN>");
                response.Success = false;
                response.Message = "Not Found Value";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Get Food In Restaurant By Id</PROCESS>");
                response.Data = _mapper.Map<ResponseGetFood>(getFoodById);
            }

            _logger.LogInfo("<END>Get Food In Restaurant By Id</END>");

            return response;
        }

        public async Task<ServiceResponse<ResponseGetFood>> UpdateFood(RequestUpdateFood request)
        {
            _logger.LogInfo("<START>Update Food</START>");

            var response = new ServiceResponse<ResponseGetFood>();

            var updateFood = await _repository.UpdateFood(_mapper.Map<Food>(request));

            if (updateFood == null)
            {
                _logger.LogError("<ERROR>Can't Update Food</ERROR>");
                response.Success = false;
                response.Message = "Can't Update Value";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Update Food</PROCESS>");
                response.Data = _mapper.Map<ResponseGetFood>(updateFood);
            }

            _logger.LogInfo("<END>Update Food</END>");

            return response;
        }
    }
}