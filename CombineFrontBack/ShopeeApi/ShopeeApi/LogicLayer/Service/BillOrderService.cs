using AutoMapper;
using LoggerService;
using ShopeeApi.Dtos.Request;
using ShopeeApi.Dtos.Response;
using ShopeeApi.IRepository;
using ShopeeApi.IService;
using ShopeeApi.Models;

namespace ShopeeApi.Service
{
    public class BillOrderService : IBillOrderService
    {
        private readonly IBillOrderRepository _billRepository;
        private readonly ITransferOrderRepository _transferRepository;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public BillOrderService(IBillOrderRepository billRepository, ITransferOrderRepository transferRepository, IMapper mapper, ILoggerManager logger)
        {
            _billRepository = billRepository;
            _transferRepository = transferRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ServiceResponse<ResponseBillOrder>> CreateBillAllOrderProcess(string username)
        {
            _logger.LogInfo("<START>Create Bill All Order Process</START>");

            var response = new ServiceResponse<ResponseBillOrder>();

            var createBill = await _billRepository.CreateBillAllOrderProcess(username);

            if (createBill == null)
            {
                _logger.LogInfo("<ERROR>Can't Create Bill</ERROR>");
                response.Success = false;
                response.Message = "Can't Create Bill";
            }

            else
            {
                _logger.LogInfo("<PROCESS>Create Bill All Order Process</PROCESS>");
                response.Data = _mapper.Map<ResponseBillOrder>(createBill);
            }

            _logger.LogInfo("<END>Create Bill All Order Process</END>");

            return response;
        }

        public async Task<ServiceResponse<ResponseBillOrder>> CreateBillOrder(RequestAddBillOrder request)
        {
            _logger.LogInfo("<START>Create Bill Order Process</START>");

            var response = new ServiceResponse<ResponseBillOrder>();

            TransferOrder valueCheck = new TransferOrder
            {
                Username = request.CreatedBy,
                OrderId = request.OrderId
            };

            var checkIsPayment = await _transferRepository.isTransferOrderPayment(valueCheck);

            if (checkIsPayment)
            {
                _logger.LogInfo("<ERROR>Can't Create Bill</ERROR>");
                response.Success = false;
                response.Message = "Can't Create Bill";
            }

            else
            {
                try
                {
                    _logger.LogInfo("<PROCESS>Create Bill Order Process</PROCESS>");
                    TransferOrder newValueTransfer = new TransferOrder
                    {
                        Username = request.CreatedBy,
                        OrderId = request.OrderId,
                    };

                    var checkExistTransfer = await _transferRepository.isExistTransferOrder(newValueTransfer);

                    if (!checkExistTransfer)
                    {
                        throw new Exception();
                    }

                    var newBill = await _billRepository.CreateBillOrder(_mapper.Map<BillOrder>(request));

                    if (newBill == null)
                    {
                        throw new Exception();
                    }

                    newValueTransfer.BillOrderId = newBill.BillId;

                    var updatedTransfer = await _transferRepository.UpdateTransferOrder(newValueTransfer);

                    if (updatedTransfer == null)
                    {
                        throw new Exception();
                    }

                    response.Data = _mapper.Map<ResponseBillOrder>(newBill);

                }

                catch(Exception e)
                {
                    _logger.LogInfo("<ERROR>Can't Create Bill</ERROR>");
                    Console.WriteLine(e.Message);
                    response.Success = false;
                    response.Message = "Can't Create Bill";
                }

            }

            _logger.LogInfo("<END>Create Bill Order Process</END>");

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseBillOrder>>> GetAllBillOrder(string username)
        {
            _logger.LogInfo("<START>Get All Bill Order</START>");

            var response = new ServiceResponse<IEnumerable<ResponseBillOrder>>();

            var getAllBill = await _billRepository.GetAllBillOrder(username);

            if (getAllBill.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Not Found Any Value</WARN>");
                response.Success = false;
                response.Message = "Not Found Any Value";
            }

            else
            {
                _logger.LogInfo("<PROCESS>Get All Bill Order</PROCESS>");
                response.Data = getAllBill.Select(x => _mapper.Map<ResponseBillOrder>(x));
            }

            _logger.LogInfo("<END>Get All Bill Order</END>");

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseBillOrder>>> GetAllBillOrderIncludeOrder(string username)
        {
            _logger.LogInfo("<START>Get All Bill Order Include Order</START>");

            var response = new ServiceResponse<IEnumerable<ResponseBillOrder>>();

            var getAllBill = await _billRepository.GetAllBillOrderIncludeOrder(username);

            if (getAllBill.ToList().Count <= 0)
            {
                _logger.LogWarning("<WARN>Not Found Any Value</WARN>");
                response.Success = false;
                response.Message = "Not Found Any Value";
            }

            else
            {
                _logger.LogInfo("<PROCESS>Get All Bill Order Include Order</PROCESS>");
                response.Data = getAllBill.Select(x => _mapper.Map<ResponseBillOrder>(x));
            }

            _logger.LogInfo("<END>Get All Bill Order Include Order</END>");

            return response;
        }
    }
}
