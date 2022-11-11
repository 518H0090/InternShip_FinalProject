using Microsoft.AspNetCore.Mvc;
using ShopeeApi.Dtos.Request;
using ShopeeApi.IService;

namespace ShopeeApi.Controllers
{
    [Route("api/restaurant-order")]
    [ApiController]
    public class RestaurantOrderController : ControllerBase
    {
        private readonly IRestaurantOrderService _service;

        public RestaurantOrderController(IRestaurantOrderService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("all-restaurant-order")]
        public async Task<IActionResult> GetAllRestaurantOrder([FromBody] RequestAllRestaurantOrder request)
        {
            var getAllResOrder = await _service.GetAllRestaurantOrder(request.RestaurantId, request.Username);

            if (getAllResOrder.Data == null)
            {
                return BadRequest(getAllResOrder);
            }

            return Ok(getAllResOrder);
        }

        [HttpPost]
        [Route("new-restaurant-order")]
        public async Task<IActionResult> CreateRestaurantOrder([FromBody] RequestAddResOrder request)
        {
            var newOrder = await _service.NewRestaurantOrder(request);

            if (newOrder.Data == null)
            {
                return BadRequest(newOrder);
            }

            return Ok(newOrder);
        }

        [HttpDelete]
        [Route("delete-restaurant-order")]
        public async Task<IActionResult> DeleteRestaurantOrder([FromBody] RequestDeleteRestaurantOrder request)
        {
            var deleteOrder = await _service.DeleteRestaurantOrder(request);

            if (deleteOrder.Success == false)
            {
                return BadRequest(deleteOrder);
            }

            return Ok(deleteOrder);
        }
    }
}