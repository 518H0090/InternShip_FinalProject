using Microsoft.AspNetCore.Mvc;
using ShopeeApi.Dtos.Request;
using ShopeeApi.IService;

namespace ShopeeApi.Controllers
{
    [Route("api/transfer-order")]
    [ApiController]
    public class TransferOrderController : ControllerBase
    {
        private readonly ITransferOrderService _service;

        public TransferOrderController(ITransferOrderService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("all-transfer-order")]
        public async Task<IActionResult> GetAllTransferOrder([FromHeader(Name = "username")] string username)
        {
            var getAllOrder = await _service.GetAllTransferOrder(username);

            if (getAllOrder.Data == null)
            {
                return BadRequest(getAllOrder);
            }

            return Ok(getAllOrder);
        }

        [HttpGet]
        [Route("all-transfer-order-process")]
        public async Task<IActionResult> GetAllTransferOrderProcess([FromHeader(Name = "username")] string username)
        {
            var getAllOrder = await _service.GetAllTransferOrderProcess(username);

            if (getAllOrder.Data == null)
            {
                return BadRequest(getAllOrder);
            }

            return Ok(getAllOrder);
        }

        [HttpPost]
        [Route("new-transfer-order")]
        public async Task<IActionResult> CreateTransferOrder([FromBody] RequestAddTransferOrder request)
        {
            var newOrder = await _service.CreateTransferOrder(request);

            if (newOrder.Data == null)
            {
                return BadRequest(newOrder);
            }

            return Ok(newOrder);
        }

        [HttpDelete]
        [Route("delete-transfer-order")]
        public async Task<IActionResult> DeleteTransferOrder([FromBody] RequestDeleteTransferOrder request)
        {
            var deleteOrder = await _service.DeleteTransferOrder(request);

            if (deleteOrder.Data == null)
            {
                return BadRequest(deleteOrder);
            }

            return Ok(deleteOrder);
        }
    }
}