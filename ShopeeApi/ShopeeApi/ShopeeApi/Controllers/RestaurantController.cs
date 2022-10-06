using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopeeApi.Dtos;
using ShopeeApi.Models;
using ShopeeApi.Repository;
using ShopeeApi.Service;

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
        [Route("GetAllRestaurants")]
        public async Task<IActionResult> GetAllRestaurants()
        {
            return Ok(await _service.GetAllRestaurant());
        }

        [HttpGet]
        [Route("GetRestaurantById/{id}")]
        public async Task<IActionResult> GetRestaurantById(int id)
        {
            return Ok(await _service.GetRestaurantById(id));
        }

        [HttpGet]
        [Route("ViewPromotion")]
        public async Task<IActionResult> ViewPromotion()
        {
            //return Ok(Enum.GetValues(typeof(Promotion)));
            //return Ok(JsonConvert.SerializeObject(new
            //{
            //    Promotion.reduce,
            //    Promotion.reduce10K,
            //    Promotion.reduce20K,
            //    Promotion.reduce30K,
            //    Promotion.reduce40K
            //}, new Newtonsoft.Json.Converters.StringEnumConverter()));

            return Ok(JsonConvert.SerializeObject(Enum.GetNames(typeof(Promotion)).ToList()
                , new Newtonsoft.Json.Converters.StringEnumConverter()));
        }

        [HttpPost]
        [Route("NewRestaurant")]
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
        [Route("UpdateRestaurant/{id}")]
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
        [Route("DeleteRestaurant/{id}")]
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
