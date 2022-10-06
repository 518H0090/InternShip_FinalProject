﻿using AutoMapper;
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
                serviceResponse.Success = false;
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
                serviceResponse.Success = false;
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

            if (getAllResFromRepo.ToList().Count <= 0)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Don't Have Any Data";
            } 
            
            else
            {
                var responseAllRes = getAllResFromRepo.Select(u => _mapper.Map<ResponseGetRestaurant>(u)).ToList();

                serviceResponse.Data = responseAllRes;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetRestaurantWithCategoryTag>>> GetAllRestaurantWithTag()
        {
            var serviceResponse = new ServiceResponse<IEnumerable<ResponseGetRestaurantWithCategoryTag>>();

            var getAllRestaurantAndTheirCategoryTag = await _repository.GetAllRestaurantWithCategoryTag();

            if (getAllRestaurantAndTheirCategoryTag.ToList().Count <= 0)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Don't Have Any Data";
            } 
            
            else
            {
                serviceResponse.Data = getAllRestaurantAndTheirCategoryTag
                    .Select(x => _mapper.Map<ResponseGetRestaurantWithCategoryTag>(x)).ToList();
            }

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
                serviceResponse.Message = $"Over Range or Not Exist or {e.Message}";
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
