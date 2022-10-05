using AutoMapper;
using ShopeeApi.Dtos;
using ShopeeApi.Models;
using ShopeeApi.Repository;

namespace ShopeeApi.Service
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _repository;
        private readonly IMapper _mapper;

        public RestaurantService(IRestaurantRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<ResponseGetRestaurant>> CreateRestaurant(RequestAddRestaurant request)
        {
            ServiceResponse<ResponseGetRestaurant> serviceResponse = new ServiceResponse<ResponseGetRestaurant>();

            if (await _repository.ExistRestaurant(request.RsTitle))
            {
                serviceResponse.Message = "Exists Restaurant";
            } 
            
            else
            {
                var newRestaurant = _mapper.Map<Restaurant>(request);

                var createdRestaurant = await _repository.CreateRestaurant(newRestaurant);

                serviceResponse.Data = _mapper.Map<ResponseGetRestaurant>(createdRestaurant);
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<string>> DeleteRestaurant(int ResId)
        {
            ServiceResponse<string> serviceResponse = new ServiceResponse<string>();

            var checkDelete = await _repository.DeleteRestaurant(ResId);

            if (checkDelete == false)
            {
                serviceResponse.Success = checkDelete;
                serviceResponse.Message = "Can't Delete Restaurant";
            } 
            
            else
            {
                serviceResponse.Data = "Delete Success";
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetRestaurant>>> GetAllRestaurant()
        {
            var serviceResponse = new ServiceResponse<IEnumerable<ResponseGetRestaurant>>();

            var getAllResFromRepo = await _repository.GetAllRestaurant();

            var responseAllRes = getAllResFromRepo.Select(u => _mapper.Map<ResponseGetRestaurant>(u)).ToList();

            serviceResponse.Data = responseAllRes;

            return serviceResponse;
        }

        public async Task<ServiceResponse<ResponseGetRestaurant>> GetRestaurantById(int ResId)
        {
            var serviceResponse = new ServiceResponse<ResponseGetRestaurant>();

           try
            {
                var getResByIdRepo = await _repository.GetRestaurantById(ResId);

                serviceResponse.Data = _mapper.Map<ResponseGetRestaurant>(getResByIdRepo);
            } 
            
            catch(Exception e)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Over Range or Not Exist";
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<ResponseGetRestaurant>> UpdateRestaurant(int ResId, RequestEditRestaurant request)
        {
            var serviceResponse = new ServiceResponse<ResponseGetRestaurant>();

            var valueNeedUpdate = _mapper.Map<Restaurant>(request);

            var updateRes = await _repository.UpdateRestaurant(ResId, valueNeedUpdate);

            if (updateRes == null)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Can't Update Restaurant";
            } 
            
            else
            {
                var newValueUpdate = _mapper.Map<ResponseGetRestaurant>(updateRes);
                serviceResponse.Data = newValueUpdate;
            }

            return serviceResponse;
        }
    }
}
