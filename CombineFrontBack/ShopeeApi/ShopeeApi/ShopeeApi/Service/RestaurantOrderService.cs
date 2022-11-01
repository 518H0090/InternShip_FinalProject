using AutoMapper;
using LoggerService;
using ShopeeApi.Dtos;
using ShopeeApi.Models;
using ShopeeApi.Repository;

namespace ShopeeApi.Service
{
    public class RestaurantOrderService : IRestaurantOrderService
    {
        private readonly IRestaurantOrderRepository _repository;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public RestaurantOrderService(IRestaurantOrderRepository repository, IMapper mapper, ILoggerManager logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ServiceResponse<ResponseRestaurantOrder>> DeleteRestaurantOrder(RequestDeleteRestaurantOrder request)
        {
            _logger.LogInfo("<START>Delete Restaurant Order</START>");

            var response = new ServiceResponse<ResponseRestaurantOrder>();

            var checkExistRecord = await _repository.GetRestaurantOrderByFoodTitle(request.RestaurantId, request.UserName, request.FoodTitle);

            if (checkExistRecord != null)
            {
                var getFoodCount = checkExistRecord.CountFoodChoice;

                if (getFoodCount > 1)
                {
                    _logger.LogInfo("<PROCESS>Decrease Restaurant Order Count</PROCESS>");
                    var requestUpdate = _mapper.Map<RequestUpdateResOrder>(request);
                    var updateOrder = await _repository.UpdateRestaurantOrderDecrease(requestUpdate);

                    response.Data = _mapper.Map<ResponseRestaurantOrder>(updateOrder);
                }

                else
                {

                    var deleteOrder = await _repository.DeleteRestaurant(request.RestaurantId, request.UserName, request.FoodTitle);

                    if (deleteOrder)
                    {
                        _logger.LogInfo("<PROCESS>Delete Restaurant Order</PROCESS>");
                        response.Message = "Delete Succesfully";
                    }

                    else
                    {
                        _logger.LogError("<ERROR>Can't Delete Order</ERROR>");
                        response.Success = false;
                        response.Message = "Can't Delete Record";
                    }
                }
            }

            else if (checkExistRecord == null)
            {
                _logger.LogError("<ERROR>Can't Delete Order</ERROR>");
                response.Success = false;
                response.Message = "Can't Delete Record";
            }

            _logger.LogInfo("<END>Delete Restaurant Order</END>");

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseRestaurantOrder>>> GetAllRestaurantOrder(int restaurantId, string userName)
        {
            _logger.LogInfo("<START>Get All Restaurant Order</START>");

            var response = new ServiceResponse<IEnumerable<ResponseRestaurantOrder>>();

            var getAllResOrderFollowUser = await _repository.GetAllRestaurantOrder(restaurantId, userName);

            if (getAllResOrderFollowUser == null || getAllResOrderFollowUser.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Can't Get All Restaurant Order</WARN>");
                response.Success = false;
                response.Message = "Not Found Any Restaurant Order";
            }

            else
            {
                _logger.LogInfo("<PROCESS>Get All Restaurant Order</PROCESS>");
                response.Data = getAllResOrderFollowUser.Select(x => _mapper.Map<ResponseRestaurantOrder>(x));
            }

            _logger.LogInfo("<END>Get All Restaurant Order</END>");


            return response;
        }

        public async Task<ServiceResponse<ResponseRestaurantOrder>> NewRestaurantOrder(RequestAddResOrder request)
        {
            _logger.LogInfo("<START>New Restaurant Order</START>");

            var response = new ServiceResponse<ResponseRestaurantOrder>();

            var checkExistRecord = await _repository.ExistRecord(request.RestaurantId, request.UserName, request.FoodTitle);

            if (checkExistRecord)
            {
                _logger.LogInfo("<PROCESS>Update Restaurant Order Count</PROCESS>");
                var requestUpdate = _mapper.Map<RequestUpdateResOrder>(request);
                var updateOrder = await _repository.UpdateRestaurantOrder(requestUpdate);

                response.Data = _mapper.Map<ResponseRestaurantOrder>(updateOrder);
            } 

            else if (!checkExistRecord)
            {
                _logger.LogInfo("<PROCESS>New Restaurant Order</PROCESS>");

                var newOrder = await _repository.NewRestaurantOrder(request);

                response.Data = _mapper.Map<ResponseRestaurantOrder>(newOrder);
            }
            
            else
            {
                _logger.LogError("<ERROR>Can't Create Restaurant Order</ERROR>");

                response.Success = false;
                response.Message = "Can't Create Order";
            }

            _logger.LogInfo("<END>New Restaurant Order</END>");

            return response;
        }
    }
}
