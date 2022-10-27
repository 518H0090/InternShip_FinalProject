using AutoMapper;
using LoggerService;
using ShopeeApi.Dtos;
using ShopeeApi.Models;
using ShopeeApi.Repository;

namespace ShopeeApi.Service
{
    public class BillService : IBillService
    {
        private readonly IBillRepository _repository;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public BillService(IBillRepository repository, IMapper mapper, ILoggerManager logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ServiceResponse<ResponseGetBill>> CreateNewBill(RequestAddBill request)
        {
            _logger.LogInfo("<START>Create New Bill</START>");

            var response = new ServiceResponse<ResponseGetBill>();

            if (await _repository.ExistsUserName(request.UseName))
            {
                var newBill = await _repository.CreateNewBill(_mapper.Map<Bill>(request));

                if (newBill == null)
                {
                    _logger.LogError("<ERROR>Can't Create New Bill</ERROR>");
                    response.Message = "Can't Create Bill";
                    response.Success = false;
                }

                else
                {
                    _logger.LogInfo("<PROCESS>Create New Bill</PROCESS>");
                    response.Data = _mapper.Map<ResponseGetBill>(newBill);
                }
            }

            else
            {
                _logger.LogError("<ERROR>Can't Create New Bill</ERROR>");
                response.Message = "Can't Create Bill";
                response.Success = false;
            }

            _logger.LogInfo("<END>Create New Bill</END>");

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetBill>>> GetAllBill()
        {
            _logger.LogInfo("<START>Get All Bill</START>");

            var response = new ServiceResponse<IEnumerable<ResponseGetBill>>();

            var getAllBill = await _repository.GetAllBill();

            if (getAllBill.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Can't Get All Bill</WARN>");
                response.Message = "Not Have Any Value";
                response.Success = false;
            }

            else
            {
                _logger.LogInfo("<PROCESS>Get All Bill</PROCESS>");
                response.Data = getAllBill.Select(x => _mapper.Map<ResponseGetBill>(x));
            }

            _logger.LogInfo("<END>Get All Bill</END>");

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetBill>>> GetAllBillFollowUsername(string username)
        {
            _logger.LogInfo("<START>Get All Bill Follow Username</START>");

            var response = new ServiceResponse<IEnumerable<ResponseGetBill>>();

            var getAllBill = await _repository.GetAllBillFollowUsername(username);

            if (getAllBill.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Get All Bill Follow Username</WARN>");
                response.Message = "Not Have Any Value";
                response.Success = false;
            }

            else
            {
                _logger.LogInfo("<PROCESS>Get All Bill Follow Username</PROCESS>");
                response.Data = getAllBill.Select(x => _mapper.Map<ResponseGetBill>(x));
            }

            _logger.LogInfo("<END>Get All Bill Follow Username</END>");

            return response;
        }
    }
}
