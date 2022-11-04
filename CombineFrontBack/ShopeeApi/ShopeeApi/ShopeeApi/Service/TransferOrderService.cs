using AutoMapper;
using LoggerService;
using ShopeeApi.Dtos;
using ShopeeApi.Models;
using ShopeeApi.Repository;

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
            var response = new ServiceResponse<ResponseTransferOrder>();

            var checkUserExist = await _repository.ExistUser(request.Username);

            if (checkUserExist)
            {
                var newTransferOder = await _repository.CreateTransferOrder(_mapper.Map<TransferOrder>(request), request.RestaurantId);

                if (newTransferOder == null)
                {
                    response.Success = false;
                    response.Message = "Can't Create Transfer Order";
                }

                response.Data = _mapper.Map<ResponseTransferOrder>(newTransferOder);
            }

            else
            {
                response.Success = false;
                response.Message = "Not Found User";
            }

            return response;

        }

        public async Task<ServiceResponse<string>> DeleteTransferOrder(RequestDeleteTransferOrder request)
        {
            var response = new ServiceResponse<string>();

            var checkIsOrderFinish = await _repository.isTransferOrderPayment(_mapper.Map<TransferOrder>(request));

            if (checkIsOrderFinish)
            {
                var deleteOrder = await _repository.DeleteTransferOrder(_mapper.Map<TransferOrder>(request));

                if (!deleteOrder)
                {
                    response.Success = false;
                    response.Message = "Can't Delete Order";
                }

                response.Data = "Delete Succesfully";
            }

            else
            {
                response.Success = false;
                response.Message = "Can't Delete Order";
            }

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseTransferOrder>>> GetAllTransferOrder(string username)
        {
            var response = new ServiceResponse<IEnumerable<ResponseTransferOrder>>();

            var getAllOrder = await _repository.GetAllTransferOrder(username);

            if (getAllOrder.ToList().Count <= 0)
            {
                response.Success = false;
                response.Message = "Not Found Any Value";
            }

            else
            {
                response.Data = getAllOrder.Select(x => _mapper.Map<ResponseTransferOrder>(x));
            }

            return response;
        }

        
    }
}
