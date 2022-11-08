using AutoMapper;
using LoggerService;
using ShopeeApi.Dtos.Request;
using ShopeeApi.Dtos.Response;
using ShopeeApi.IRepository;
using ShopeeApi.IService;
using ShopeeApi.Models;

namespace ShopeeApi.Service
{
    public class RecordService : IRecordService
    {
        private readonly IRecordRepository _repository;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public RecordService(IRecordRepository repository, IMapper mapper, ILoggerManager logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ServiceResponse<string>> DeleteRecord(RequestDeleteFoodRecord request)
        {
            _logger.LogInfo("<START>DELETE RECORD</START>");

            var response = new ServiceResponse<string>();

            var getNewRecord = await _repository.DeleteRecord(request.RecordId, request.Username);

            if (!getNewRecord)
            {
                _logger.LogError("<ERROR>Can't Delete Item In Shopping Card</ERROR>");
                response.Message = "Can't Delete Item In Shopping Card";
                response.Success = false;
            }

            else
            {
                _logger.LogInfo("<PROCESS>Delete Successful</PROCESS>");
                response.Data = "Delete Successful";
            }

            _logger.LogInfo("<END>DELETE RECORD</END>");

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetFoodRecord>>> GetAllRecordFollowUsername(string username)
        {
            _logger.LogInfo("<START>Get All Record Follow Username</START>");
            var response = new ServiceResponse<IEnumerable<ResponseGetFoodRecord>>();

            var getAllRecordFollowUser = await _repository.GetAllRecordFollowUsername(username);

            if (getAllRecordFollowUser == null || getAllRecordFollowUser.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Can't Find Any Item In Shopping Card</WARN>");
                response.Success = false;
                response.Message = "Can't Find Any value";
            }

            else
            {
                _logger.LogInfo("<PROCESS>Get All Record Follow Username</PROCESS>");
                response.Data = getAllRecordFollowUser.Select(x => _mapper.Map<ResponseGetFoodRecord>(x));
            }

            _logger.LogInfo("<END>Get All Record Follow Username</END>");

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetFoodRecord>>> GetTop6RecordFollowUsername(string username)
        {
            _logger.LogInfo("<START>Get Top6 Record Follow Username</START>");

            var response = new ServiceResponse<IEnumerable<ResponseGetFoodRecord>>();

            var get6RecordFollowUser = await _repository.GetTop6RecordFollowUsername(username);

            if (get6RecordFollowUser == null || get6RecordFollowUser.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Can't Find Top6 Record Follow Username</WARN>");
                response.Success = false;
                response.Message = "Can't Find Any value";
            }

            else
            {
                _logger.LogInfo("<PROCESS>Get Top6 Record Follow Username</PROCESS>");
                response.Data = get6RecordFollowUser.Select(x => _mapper.Map<ResponseGetFoodRecord>(x));
            }

            _logger.LogInfo("<END>Get Top6 Record Follow Username</END>");

            return response;
        }

        public async Task<ServiceResponse<ResponseGetFoodRecord>> NewRecord(RequestAddFoodRecord request, string username)
        {
            _logger.LogInfo("<START>New Record</START>");

            var response = new ServiceResponse<ResponseGetFoodRecord>();

            var getNewRecord = await _repository.NewRecord(_mapper.Map<SelectFoodRecord>(request),username);

            if (getNewRecord == null)
            {
                _logger.LogError("<ERROR>Can't Add New Item</ERROR>");
                response.Message = "Can't Add Item In Shopping Card";
                response.Success = false;
            }

            else
            {
                _logger.LogInfo("<PROCESS>New Record</PROCESS>");
                response.Data = _mapper.Map<ResponseGetFoodRecord>(getNewRecord);
            }

            _logger.LogInfo("<END>New Record</END>");

            return response;
        }
    }
}
