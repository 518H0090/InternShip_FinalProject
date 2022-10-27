using AutoMapper;
using LoggerService;
using ShopeeApi.Dtos;
using ShopeeApi.Models;
using ShopeeApi.Repository;

namespace ShopeeApi.Service
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _repository;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public RestaurantService(IRestaurantRepository repository, IMapper mapper, ILoggerManager logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ServiceResponse<ResponseGetRestaurant>> CreateRestaurant(RequestAddRestaurant request)
        {
            _logger.LogInfo("<START>New Restaurant</START>");
            ServiceResponse<ResponseGetRestaurant> serviceResponse = new ServiceResponse<ResponseGetRestaurant>();

            if (await _repository.ExistRestaurant(request.RsTitle))
            {
                _logger.LogWarning("<WARN>Exist Restaurant</WARN>");
                serviceResponse.Message = "Exists Restaurant";
                serviceResponse.Success = false;
            }
            else
            {
                _logger.LogInfo("<PROCESS>Create New Restaurant</PROCESS>");

                var newRestaurant = _mapper.Map<Restaurant>(request);

                var createdRestaurant = await _repository.CreateRestaurant(newRestaurant);

                serviceResponse.Data = _mapper.Map<ResponseGetRestaurant>(createdRestaurant);
            }

            _logger.LogInfo("<END>New Restaurant</END>");

            return serviceResponse;
        }

        public async Task<ServiceResponse<string>> DeleteRestaurant(int ResId)
        {
            _logger.LogInfo("<START>Delete Restaurant</START>");

            ServiceResponse<string> serviceResponse = new ServiceResponse<string>();

            var checkDelete = await _repository.DeleteRestaurant(ResId);

            if (checkDelete == false)
            {
                _logger.LogError("<ERROR>Can't Delete Restaurant</ERROR>");
                serviceResponse.Success = false;
                serviceResponse.Message = "Can't Delete Restaurant";
            }
            else
            {
                serviceResponse.Data = "Delete Success";
            }

            _logger.LogInfo("<END>Delete Restaurant</END>");

            return serviceResponse;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetRestaurant>>> GetAllRestaurant()
        {
            _logger.LogInfo("<START>Get All Restaurant</START>");
            var serviceResponse = new ServiceResponse<IEnumerable<ResponseGetRestaurant>>();

            var getAllResFromRepo = await _repository.GetAllRestaurant();

            if (getAllResFromRepo.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Can't Find Any Restaurants</WARN>");

                serviceResponse.Success = false;
                serviceResponse.Message = "Don't Have Any Data";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Return Restaurants</PROCESS>");

                var responseAllRes = getAllResFromRepo.Select(u => _mapper.Map<ResponseGetRestaurant>(u)).ToList();

                serviceResponse.Data = responseAllRes;
            }

            _logger.LogInfo("<END>Get All Restaurant</END>");

            return serviceResponse;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetRestaurantWithCategoryTag>>> GetAllRestaurantWithTag()
        {
            _logger.LogInfo("<START>Get List Restaurant With Tag</START>");

            var serviceResponse = new ServiceResponse<IEnumerable<ResponseGetRestaurantWithCategoryTag>>();

            var getAllRestaurantAndTheirCategoryTag = await _repository.GetAllRestaurantWithCategoryTag();

            if (getAllRestaurantAndTheirCategoryTag.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Can't Find Any Restaurant With Its Tag</WARN>");
                serviceResponse.Success = false;
                serviceResponse.Message = "Don't Have Any Data";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Get List Restaurant with Tag</PROCESS>");
                serviceResponse.Data = getAllRestaurantAndTheirCategoryTag
                    .Select(x => _mapper.Map<ResponseGetRestaurantWithCategoryTag>(x)).ToList();
            }

            _logger.LogInfo("<END>Get List Restaurant With Tag</END>");

            return serviceResponse;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetRestaurantWithFood>>> GetAllRestaurantWithFood()
        {
            _logger.LogInfo("<START>Get List Restaurant With Food</START>");
            var serviceResponse = new ServiceResponse<IEnumerable<ResponseGetRestaurantWithFood>>();

            var ResponseGetRestaurantFood = await _repository.GetAllRestaurantWithFood();

            if (ResponseGetRestaurantFood.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Can't Find Any Restaurant With Its Food</WARN>");
                serviceResponse.Success = false;
                serviceResponse.Message = "Don't Have Any Data";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Get List Restaurant with Food</PROCESS>");
                serviceResponse.Data = ResponseGetRestaurantFood
                    .Select(x => _mapper.Map<ResponseGetRestaurantWithFood>(x)).ToList();
            }

            _logger.LogInfo("<END>Get List Restaurant With Food</END>");

            return serviceResponse;
        }

        public async Task<ServiceResponse<ResponseGetRestaurant>> GetRestaurantById(int ResId)
        {
            _logger.LogInfo("<START>Get List Restaurant By Id</START>");
            var serviceResponse = new ServiceResponse<ResponseGetRestaurant>();

            try
            {
                _logger.LogInfo("<PROCESS>Find Restaurant By Id</PROCESS>");
                var getResByIdRepo = await _repository.GetRestaurantById(ResId);

                serviceResponse.Data = _mapper.Map<ResponseGetRestaurant>(getResByIdRepo);
            }
            catch (Exception e)
            {
                _logger.LogError("<ERROR>Can't Find Restaurant By Id</ERROR>");
                serviceResponse.Success = false;
                serviceResponse.Message = $"Over Range or Not Exist or {e.Message}";
            }

            _logger.LogInfo("<END>Get List Restaurant By Id</END>");
            return serviceResponse;
        }

        public async Task<ServiceResponse<ResponseGetRestaurant>> UpdateRestaurant(int ResId, RequestEditRestaurant request)
        {
            _logger.LogInfo("<START>UpdateRestaurant</START>");
            var serviceResponse = new ServiceResponse<ResponseGetRestaurant>();

            var valueNeedUpdate = _mapper.Map<Restaurant>(request);

            var updateRes = await _repository.UpdateRestaurant(ResId, valueNeedUpdate);

            if (updateRes == null)
            {
                _logger.LogError("<ERROR>Can't Update Restaurant</ERROR>");
                serviceResponse.Success = false;
                serviceResponse.Message = "Can't Update Restaurant";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Update Restaurant</PROCESS>");
                var newValueUpdate = _mapper.Map<ResponseGetRestaurant>(updateRes);
                serviceResponse.Data = newValueUpdate;
            }
            _logger.LogInfo("<END>UpdateRestaurant</END>");
            return serviceResponse;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetRestaurantWithFoodTag>>> GetAllRestaurantWithFoodTag()
        {
            _logger.LogInfo("<START>Get List Restaurant With FoodTag</START>");
            var response = new ServiceResponse<IEnumerable<ResponseGetRestaurantWithFoodTag>>();

            var getAllRestaurantWithTheirFoodTag = await _repository.GetAllRestaurantWithCategoryTagAndFood();

            if (getAllRestaurantWithTheirFoodTag.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Can't Find Any Restaurant With FoodTag</WARN>");
                response.Success = false;
                response.Message = "Not Found Any Value";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Return List Restaurant With FoodTag</PROCESS>");
                response.Data = getAllRestaurantWithTheirFoodTag.Select(x => _mapper.Map<ResponseGetRestaurantWithFoodTag>(x));
            }

            _logger.LogInfo("<END>Get List Restaurant With FoodTag</END>");

            return response;
        }

        public async Task<ServiceResponse<ResponseGetRestaurantWithFoodTag>> GetRestaurantByIdWithTagAndFood(int ResId)
        {
            _logger.LogInfo("<START>Get Restaurant By Id With Tag And Food</START>");
            var response = new ServiceResponse<ResponseGetRestaurantWithFoodTag>();

            var getRestaurantWithTheirFoodTag = await _repository.GetRestaurantByIdWithTagAndFood(ResId);

            if (getRestaurantWithTheirFoodTag == null)
            {
                _logger.LogWarning("<WARN>Can't Find Restaurant With Tag And Food</WARN>");
                response.Success = false;
                response.Message = "Not Found Value";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Find Restaurant With Tag And Food</PROCESS>");
                response.Data = _mapper.Map<ResponseGetRestaurantWithFoodTag>(getRestaurantWithTheirFoodTag);
            }

            _logger.LogInfo("<END>Get Restaurant By Id With Tag And Food</END>");

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetRestaurant>>> GetAllRestaurantTop9()
        {
            _logger.LogInfo("<START>Get Top 9 Restaurant</START>");
            var serviceResponse = new ServiceResponse<IEnumerable<ResponseGetRestaurant>>();

            var getAllResFromRepo = await _repository.GetAllRestaurantTop9();

            if (getAllResFromRepo.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Can't Find Top 9 Restaurant</WARN>");
                serviceResponse.Success = false;
                serviceResponse.Message = "Don't Have Any Data";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Find Top 9 Restaurant</PROCESS>");
                var responseAllRes = getAllResFromRepo.Select(u => _mapper.Map<ResponseGetRestaurant>(u)).ToList();

                serviceResponse.Data = responseAllRes;
            }

            _logger.LogInfo("<END>Get Top 9 Restaurant</END>");

            return serviceResponse;
        }

        public async Task<ServiceResponse<ResponseGetRestaurantWithId>> GetRestaurantByTitle(string resTitle)
        {
            _logger.LogInfo("<START>Get Restaurant By Title</START>");

            var serviceResponse = new ServiceResponse<ResponseGetRestaurantWithId>();

            try
            {
                _logger.LogInfo("<PROCESS>Get Restaurant By Title</PROCESS>");
                var getResByIdRepo = await _repository.GetRestaurantByTitle(resTitle);

                serviceResponse.Data = _mapper.Map<ResponseGetRestaurantWithId>(getResByIdRepo);
            }
            catch (Exception e)
            {
                _logger.LogError("<ERROR>Can't Get Restaurant By Title</ERROR>");
                serviceResponse.Success = false;
                serviceResponse.Message = $"Over Range or Not Exist or {e.Message}";
            }

            _logger.LogInfo("<END>Get Restaurant By Title</END>");

            return serviceResponse;
        }
    }
}