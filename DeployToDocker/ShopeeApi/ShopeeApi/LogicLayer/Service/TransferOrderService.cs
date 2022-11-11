using AutoMapper;
using LoggerService;
using ShopeeApi.Dtos.Request;
using ShopeeApi.Dtos.Response;
using ShopeeApi.IRepository;
using ShopeeApi.IService;
using ShopeeApi.Models;

namespace ShopeeApi.Service
{
    public class TransferOrderService : ITransferOrderService
    {
        private readonly ITransferOrderRepository _repository;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public TransferOrderService(ITransferOrderRepository repository, IMapper mapper, ILoggerManager logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ServiceResponse<ResponseTransferOrder>> CreateTransferOrder(RequestAddTransferOrder request)
        {
            _logger.LogInfo("<START>Create Transfer Order</START>");

            var response = new ServiceResponse<ResponseTransferOrder>();

            var checkUserExist = await _repository.ExistUser(request.Username);

            if (checkUserExist)
            {
                var newTransferOder = await _repository.CreateTransferOrder(_mapper.Map<TransferOrder>(request), request.RestaurantId);

                if (newTransferOder == null)
                {
                    _logger.LogError("<ERROR>Can't Create Transfer Order</ERROR>");
                    response.Success = false;
                    response.Message = "Can't Create Transfer Order";
                }

                _logger.LogInfo("<PROCESS>Create Transfer Order</PROCESS>");
                response.Data = _mapper.Map<ResponseTransferOrder>(newTransferOder);
            }
            else
            {
                _logger.LogWarning("<WARN>Not Found User</WARN>");
                response.Success = false;
                response.Message = "Not Found User";
            }

            _logger.LogInfo("<END>Create Transfer Order</END>");

            return response;
        }

        public async Task<ServiceResponse<string>> DeleteTransferOrder(RequestDeleteTransferOrder request)
        {
            _logger.LogInfo("<START>Delete Transfer Order</START>");

            var response = new ServiceResponse<string>();

            var checkIsOrderFinish = await _repository.isTransferOrderPayment(_mapper.Map<TransferOrder>(request));

            if (checkIsOrderFinish)
            {
                var deleteOrder = await _repository.DeleteTransferOrder(_mapper.Map<TransferOrder>(request));

                if (!deleteOrder)
                {
                    _logger.LogError("<ERROR>Can't Delete Order</ERROR>");
                    response.Success = false;
                    response.Message = "Can't Delete Order";
                }

                _logger.LogInfo("<PROCESS>Delete Transfer Order</PROCESS>");

                response.Data = "Delete Succesfully";
            }
            else
            {
                _logger.LogError("<ERROR>Can't Delete Order</ERROR>");
                response.Success = false;
                response.Message = "Can't Delete Order";
            }

            _logger.LogInfo("<END>Delete Transfer Order</END>");

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseTransferOrder>>> GetAllTransferOrder(string username)
        {
            _logger.LogInfo("<START>Get All Transfer Order</START>");

            var response = new ServiceResponse<IEnumerable<ResponseTransferOrder>>();

            var getAllOrder = await _repository.GetAllTransferOrder(username);

            if (getAllOrder.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Not Found Any Value</WARN>");
                response.Success = false;
                response.Message = "Not Found Any Value";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Get All Transfer Order</PROCESS>");
                response.Data = getAllOrder.Select(x => _mapper.Map<ResponseTransferOrder>(x));
            }

            _logger.LogInfo("<END>Get All Transfer Order</END>");

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseTransferOrder>>> GetAllTransferOrderProcess(string username)
        {
            _logger.LogInfo("<START>Get All Transfer Order Process</START>");

            var response = new ServiceResponse<IEnumerable<ResponseTransferOrder>>();

            var getAllOrder = await _repository.GetAllTransferOrderProcess(username);

            if (getAllOrder.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Not Found Any Value</WARN>");
                response.Success = false;
                response.Message = "Not Found Any Value";
            }
            else
            {
                _logger.LogInfo("<PROCESS>Get All Transfer Order Process</PROCESS>");
                response.Data = getAllOrder.Select(x => _mapper.Map<ResponseTransferOrder>(x));
            }

            _logger.LogInfo("<END>Get All Transfer Order Process</END>");

            return response;
        }
    }
}