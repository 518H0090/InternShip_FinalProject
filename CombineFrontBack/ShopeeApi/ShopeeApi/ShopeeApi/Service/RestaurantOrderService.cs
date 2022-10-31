using AutoMapper;
using ShopeeApi.Dtos;
using ShopeeApi.Models;
using ShopeeApi.Repository;

namespace ShopeeApi.Service
{
    public class RestaurantOrderService : IRestaurantOrderService
    {
        private readonly IRestaurantOrderRepository _repository;
        private readonly IMapper _mapper;

        public RestaurantOrderService(IRestaurantOrderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<ResponseRestaurantOrder>> DeleteRestaurantOrder(RequestDeleteRestaurantOrder request)
        {
            var response = new ServiceResponse<ResponseRestaurantOrder>();

            var checkExistRecord = await _repository.GetRestaurantOrderByFoodTitle(request.RestaurantId, request.UserName, request.FoodTitle);

            if (checkExistRecord != null)
            {
                var getFoodCount = checkExistRecord.CountFoodChoice;

                if (getFoodCount > 1)
                {
                    var requestUpdate = _mapper.Map<RequestUpdateResOrder>(request);
                    var updateOrder = await _repository.UpdateRestaurantOrderDecrease(requestUpdate);

                    response.Data = _mapper.Map<ResponseRestaurantOrder>(updateOrder);
                }

                else
                {
                    var deleteOrder = await _repository.DeleteRestaurant(request.RestaurantId, request.UserName, request.FoodTitle);

                    if (deleteOrder)
                    {
                        response.Message = "Delete Succesfully";
                    }

                    else
                    {
                        response.Success = false;
                        response.Message = "Can't Delete Record";
                    }
                }
            }

            else if (checkExistRecord == null)
            {
                response.Success = false;
                response.Message = "Can't Delete Record";
            }

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseRestaurantOrder>>> GetAllRestaurantOrder(int restaurantId, string userName)
        {
            var response = new ServiceResponse<IEnumerable<ResponseRestaurantOrder>>();

            var getAllResOrderFollowUser = await _repository.GetAllRestaurantOrder(restaurantId, userName);

            if (getAllResOrderFollowUser == null || getAllResOrderFollowUser.ToList().Count <= 0)
            {
                response.Success = false;
                response.Message = "Not Found Any Restaurant Order";
            }

            else
            {
                response.Data = getAllResOrderFollowUser.Select(x => _mapper.Map<ResponseRestaurantOrder>(x));
            }


            return response;
        }

        public async Task<ServiceResponse<ResponseRestaurantOrder>> NewRestaurantOrder(RequestAddResOrder request)
        {
            var response = new ServiceResponse<ResponseRestaurantOrder>();

            var checkExistRecord = await _repository.ExistRecord(request.RestaurantId, request.UserName, request.FoodTitle);

            if (checkExistRecord)
            {
                var requestUpdate = _mapper.Map<RequestUpdateResOrder>(request);
                var updateOrder = await _repository.UpdateRestaurantOrder(requestUpdate);

                response.Data = _mapper.Map<ResponseRestaurantOrder>(updateOrder);
            } 

            else if (!checkExistRecord)
            {
                var newOrder = await _repository.NewRestaurantOrder(request);

                response.Data = _mapper.Map<ResponseRestaurantOrder>(newOrder);
            }
            
            else
            {
                response.Success = false;
                response.Message = "Can't Create Order";
            }

            return response;
        }
    }
}
