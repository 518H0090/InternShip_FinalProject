using AutoMapper;
using LoggerService;
using ShopeeApi.Dtos;
using ShopeeApi.Models;
using ShopeeApi.Repository;

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
            var response = new ServiceResponse<ResponseBillOrder>();

            var createBill = await _billRepository.CreateBillAllOrderProcess(username);

            if (createBill == null)
            {
                response.Success = false;
                response.Message = "Can't Create Bill";
            }

            else
            {
                response.Data = _mapper.Map<ResponseBillOrder>(createBill);
            }

            return response;
        }

        public async Task<ServiceResponse<ResponseBillOrder>> CreateBillOrder(RequestAddBillOrder request)
        {
            var response = new ServiceResponse<ResponseBillOrder>();

            TransferOrder valueCheck = new TransferOrder
            {
                Username = request.CreatedBy,
                OrderId = request.OrderId
            };

            var checkIsPayment = await _transferRepository.isTransferOrderPayment(valueCheck);

            if (checkIsPayment)
            {
                response.Success = false;
                response.Message = "Can't Create Bill";
            }

            else
            {
                try
                {
                    TransferOrder newValueTransfer = new TransferOrder
                    {
                        Username = request.CreatedBy,
                        OrderId = request.OrderId
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

                    var updatedTransfer = await _transferRepository.UpdateTransferOrder(newValueTransfer);

                    if (updatedTransfer == null)
                    {
                        throw new Exception();
                    }

                    response.Data = _mapper.Map<ResponseBillOrder>(newBill);

                }

                catch(Exception e)
                {
                    response.Success = false;
                    response.Message = "Can't Create Bill";
                }

            }

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseBillOrder>>> GetAllBillOrder(string username)
        {
            var response = new ServiceResponse<IEnumerable<ResponseBillOrder>>();

            var getAllBill = await _billRepository.GetAllBillOrder(username);

            if (getAllBill.ToList().Count <= 0)
            {
                response.Success = false;
                response.Message = "Not Found Any Value";
            }

            else
            {
                response.Data = getAllBill.Select(x => _mapper.Map<ResponseBillOrder>(x));
            }

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseBillOrder>>> GetAllBillOrderIncludeOrder(string username)
        {
            var response = new ServiceResponse<IEnumerable<ResponseBillOrder>>();

            var getAllBill = await _billRepository.GetAllBillOrderIncludeOrder(username);

            if (getAllBill.ToList().Count <= 0)
            {
                response.Success = false;
                response.Message = "Not Found Any Value";
            }

            else
            {
                response.Data = getAllBill.Select(x => _mapper.Map<ResponseBillOrder>(x));
            }

            return response;
        }
    }
}
