using Microsoft.AspNetCore.Mvc;
using ShopeeApi.Dtos.Request;
using ShopeeApi.IService;

namespace ShopeeApi.Controllers
{
    [Route("api/bill-order")]
    [ApiController]
    public class BillOrderController : ControllerBase
    {
        private readonly IBillOrderService _service;

        public BillOrderController(IBillOrderService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("all-bill-order")]
        public async Task<IActionResult> GetAllBillOrder([FromHeader(Name = "username")] string username)
        {
            var getAllBill = await _service.GetAllBillOrder(username);

            if (getAllBill.Data == null)
            {
                return BadRequest(getAllBill);
            }

            return Ok(getAllBill);
        }

        [HttpGet]
        [Route("all-bill-inclue-transfer")]
        public async Task<IActionResult> GetAllBillOrderIncludeTransfer([FromHeader(Name = "username")] string username)
        {
            var getAllBill = await _service.GetAllBillOrderIncludeOrder(username);

            if (getAllBill.Data == null)
            {
                return BadRequest(getAllBill);
            }

            return Ok(getAllBill);
        }

        [HttpPost]
        [Route("new-bill-order")]
        public async Task<IActionResult> CreateBillOrder([FromBody] RequestAddBillOrder request)
        {
            var newBill = await _service.CreateBillOrder(request);

            if (newBill.Data == null)
            {
                return BadRequest(newBill);
            }

            return Ok(newBill);
        }

        [HttpPost]
        [Route("new-bill-transfer-process-order")]
        public async Task<IActionResult> CreateBillTransferProcessOrder([FromHeader(Name = "username")] string username)
        {
            var newBill = await _service.CreateBillAllOrderProcess(username);

            if (newBill.Data == null)
            {
                return BadRequest(newBill);
            }

            return Ok(newBill);
        }
    }
}