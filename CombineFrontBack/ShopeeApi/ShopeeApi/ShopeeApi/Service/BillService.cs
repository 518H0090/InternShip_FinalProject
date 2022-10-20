using AutoMapper;
using ShopeeApi.Dtos;
using ShopeeApi.Models;
using ShopeeApi.Repository;

namespace ShopeeApi.Service
{
    public class BillService : IBillService
    {
        private readonly IBillRepository _repository;
        private readonly IMapper _mapper;

        public BillService(IBillRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<ResponseGetBill>> CreateNewBill(RequestAddBill request)
        {
            var response = new ServiceResponse<ResponseGetBill>();

            if (await _repository.ExistsUserName(request.UseName))
            {
                var newBill = await _repository.CreateNewBill(_mapper.Map<Bill>(request));

                if (newBill == null)
                {
                    response.Message = "Can't Create Bill";
                    response.Success = false;
                }

                else
                {
                    response.Data = _mapper.Map<ResponseGetBill>(newBill);
                }
            }

            else
            {
                response.Message = "Can't Create Bill";
                response.Success = false;
            }

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetBill>>> GetAllBill()
        {
            var response = new ServiceResponse<IEnumerable<ResponseGetBill>>();

            var getAllBill = await _repository.GetAllBill();

            if (getAllBill.ToList().Count <= 0)
            {
                response.Message = "Not Have Any Value";
                response.Success = false;
            }

            else
            {
                response.Data = getAllBill.Select(x => _mapper.Map<ResponseGetBill>(x));
            }

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetBill>>> GetAllBillFollowUsername(string username)
        {
            var response = new ServiceResponse<IEnumerable<ResponseGetBill>>();

            var getAllBill = await _repository.GetAllBillFollowUsername(username);

            if (getAllBill.ToList().Count <= 0)
            {
                response.Message = "Not Have Any Value";
                response.Success = false;
            }

            else
            {
                response.Data = getAllBill.Select(x => _mapper.Map<ResponseGetBill>(x));
            }

            return response;
        }
    }
}
