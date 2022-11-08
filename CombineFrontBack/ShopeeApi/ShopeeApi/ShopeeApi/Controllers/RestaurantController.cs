using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopeeApi.Dtos.Request;
using ShopeeApi.EnumData;
using ShopeeApi.IService;

namespace ShopeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _service;

        public RestaurantController(IRestaurantService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("all-restaurants-with-tag")]
        public async Task<IActionResult> GetAllRestaurantWithTag()
        {
            var getAllRes = await _service.GetAllRestaurantWithTag();

            if (getAllRes.Data == null)
            {
                return BadRequest(getAllRes);
            }

            return Ok(getAllRes);
        }

        [HttpGet]
        [Route("all-restaurants-with-food")]
        public async Task<IActionResult> GetAllRestaurantWithFood()
        {
            var getAllRes = await _service.GetAllRestaurantWithFood();

            if (getAllRes.Data == null)
            {
                return BadRequest(getAllRes);
            }

            return Ok(getAllRes);
        }

        [HttpGet]
        [Route("all-restaurants-with-food-tag")]
        public async Task<IActionResult> GetAllRestaurantWithFoodTag()
        {
            var getAllRes = await _service.GetAllRestaurantWithFoodTag();

            if (getAllRes.Data == null)
            {
                return BadRequest(getAllRes);
            }

            return Ok(getAllRes);
        }

        [HttpGet]
        [Route("all-restaurants")]
        public async Task<IActionResult> GetAllRestaurants()
        {
            var getAllRes = await _service.GetAllRestaurant();

            if (getAllRes.Data == null)
            {
                return BadRequest(getAllRes);
            }

            return Ok(getAllRes);
        }

        [HttpGet]
        [Route("all-restaurants-top-new9")]
        public async Task<IActionResult> GetAllRestaurantsTopNew9()
        {
            var getAllRes = await _service.GetAllRestaurantTop9();

            if (getAllRes.Data == null)
            {
                return BadRequest(getAllRes);
            }

            return Ok(getAllRes);
        }

        [HttpGet]
        [Route("restaurant-by-id/{id}")]
        public async Task<IActionResult> GetRestaurantById(int id)
        {
            var getAllResById = await _service.GetRestaurantById(id);

            if (getAllResById.Data == null)
            {
                return BadRequest(getAllResById);
            }

            return Ok(getAllResById);
        }

        [HttpGet]
        [Route("restaurant-by-title/{resTitle}")]
        public async Task<IActionResult> GetRestaurantById(string resTitle)
        {
            var getAllResById = await _service.GetRestaurantByTitle(resTitle);

            if (getAllResById.Data == null)
            {
                return BadRequest(getAllResById);
            }

            return Ok(getAllResById);
        }

        [HttpGet]
        [Route("restaurant-by-id-with-food-tag/{resId}")]
        public async Task<IActionResult> GetRestaurantByIdWithFoodTag(int resId)
        {
            var getResById = await _service.GetRestaurantByIdWithTagAndFood(resId);

            if (getResById.Data == null)
            {
                return BadRequest(getResById);
            }

            return Ok(getResById);
        }

        [HttpGet]
        [Route("view-promotion")]
        public IActionResult ViewPromotion() =>
            //return Ok(Enum.GetValues(typeof(Promotion)));
            //return Ok(JsonConvert.SerializeObject(new
            //{
            //    Promotion.reduce,
            //    Promotion.reduce10K,
            //    Promotion.reduce20K,
            //    Promotion.reduce30K,
            //    Promotion.reduce40K
            //}, new Newtonsoft.Json.Converters.StringEnumConverter()));

            Ok(JsonConvert.SerializeObject(Enum.GetNames(typeof(Promotion)).ToList()
                , new Newtonsoft.Json.Converters.StringEnumConverter()));

        [HttpPost]
        [Route("new-restaurant")]
        public async Task<IActionResult> NewRestaurant(RequestAddRestaurant request)
        {
            var newRes = await _service.CreateRestaurant(request);

            if (newRes.Data == null)
            {
                return BadRequest(newRes);
            }

            return Created("CreateNewRestaurant", newRes);
        }

        [HttpPut]
        [Route("update-restaurant/{id}")]
        public async Task<IActionResult> UpdateRestaurant(int id, RequestEditRestaurant request)
        {
            var newRes = await _service.UpdateRestaurant(id, request);

            if (newRes.Data == null)
            {
                return BadRequest(newRes);
            }

            return Ok(newRes);
        }

        [HttpDelete]
        [Route("delete-restaurant/{id}")]
        public async Task<IActionResult> DeleteRestaurant(int id)
        {
            var deleteRes = await _service.DeleteRestaurant(id);

            if (deleteRes.Data == null)
            {
                return BadRequest(deleteRes);
            }

            return Ok(deleteRes);
        }
    }
}