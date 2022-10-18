using AutoMapper;
using ShopeeApi.Dtos;
using ShopeeApi.Models;
using ShopeeApi.Repository;

namespace ShopeeApi.Service
{
    public class RecordService : IRecordService
    {
        private readonly IRecordRepository _repository;
        private readonly IMapper _mapper;

        public RecordService(IRecordRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<string>> DeleteRecord(RequestDeleteFoodRecord request)
        {
            var response = new ServiceResponse<string>();

            var getNewRecord = await _repository.DeleteRecord(request.RecordId, request.Username);

            if (!getNewRecord)
            {
                response.Message = "Can't Add Item In Shopping Card";
                response.Success = false;
            }

            else
            {
                response.Data = "Delete Successful";
            }

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetFoodRecord>>> GetAllRecordFollowUsername(string username)
        {
            var response = new ServiceResponse<IEnumerable<ResponseGetFoodRecord>>();

            var getAllRecordFollowUser = await _repository.GetAllRecordFollowUsername(username);

            if (getAllRecordFollowUser == null || getAllRecordFollowUser.ToList().Count <= 0)
            {
                response.Success = false;
                response.Message = "Can't Find Any value";
            }

            else
            {
                response.Data = getAllRecordFollowUser.Select(x => _mapper.Map<ResponseGetFoodRecord>(x));
            }

            return response;
        }

        public async Task<ServiceResponse<ResponseGetFoodRecord>> NewRecord(RequestAddFoodRecord request, string username)
        {
            var response = new ServiceResponse<ResponseGetFoodRecord>();

            var getNewRecord = await _repository.NewRecord(_mapper.Map<SelectFoodRecord>(request),username);

            if (getNewRecord == null)
            {
                response.Message = "Can't Add Item In Shopping Card";
                response.Success = false;
            }

            else
            {
                response.Data = _mapper.Map<ResponseGetFoodRecord>(getNewRecord);
            }

            return response;
        }
    }
}
