using Microsoft.AspNetCore.Mvc;
using ShopeeApi.Dtos;
using ShopeeApi.Repository;
using ShopeeApi.Service;

namespace ShopeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService _service;
        private readonly IFoodRepository _repository;

        public FoodController(IFoodService service, IFoodRepository repository)
        {
            _service = service;
            _repository = repository;
        }

        [HttpGet]
        [Route("GetAllFoodWithoutRestaurant")]
        public async Task<IActionResult> GetAllFoodWithoutRestaurant()
        {
            var getAllFood = await _service.GetAllFood();

            if (getAllFood.Data == null)
            {
                return NotFound(getAllFood);
            }

            return Ok(getAllFood);
        }

        [HttpGet]
        [Route("GetTotalIndex")]
        public async Task<IActionResult> GetTotalIndex()
        {
            var allIndexPage = await _repository.AllIndexPagination();

            if (allIndexPage == 0)
            {
                return NotFound(allIndexPage);
            }

            return Ok(allIndexPage);
        }

        [HttpGet]
        [Route("GetTotalIndexWithKeywords")]
        public async Task<IActionResult> GetTotalIndex(string keywords)
        {
            var allIndexPage = await _repository.AllIndexPaginationWithKeywords(keywords);

            if (allIndexPage == 0)
            {
                return NotFound(allIndexPage);
            }

            return Ok(allIndexPage);
        }

        //Function Test
        [HttpGet]
        [Route("GetFoodWithIndex/{indexpage}")]
        public async Task<IActionResult> GetFoodWithIndex(int indexpage)
        {
            var allIndexPage = await _service.GetAllFoodPagination(indexpage);

            if (allIndexPage.Data == null)
            {
                return NotFound(allIndexPage);
            }

            return Ok(allIndexPage);
        }

        [HttpGet]
        [Route("GetFoodWithIndexAndTitle")]
        public async Task<IActionResult> GetFoodWithIndexAndTitle(int indexpage, string keywords)
        {
            var allIndexPage = await _service.GetAllFoodPaginationWithKeywords(indexpage, keywords);

            if (allIndexPage.Data == null)
            {
                return NotFound(allIndexPage);
            }

            return Ok(allIndexPage);
        }


        //End Function Test

        [HttpGet]
        [Route("GetAllFoodWithRestaurant/{resId}")]
        public async Task<IActionResult> GetAllFoodWithRestaurant(int resId)
        {
            var getAllFood = await _service.GetAllFoodInRestaurant(resId);

            if (getAllFood.Data == null)
            {
                return NotFound(getAllFood);
            }

            return Ok(getAllFood);
        }

        [HttpGet]
        [Route("GetFoodWithItsId/{foodId}")]
        public async Task<IActionResult> GetFoodWithItsId(int foodId)
        {
            var getFoodById = await _service.GetFoodById(foodId);

            if (getFoodById.Data == null)
            {
                return NotFound(getFoodById);
            }

            return Ok(getFoodById);
        }

        [HttpGet]
        [Route("GetFoodInRestaurantById")]
        public async Task<IActionResult> GetFoodInRestaurantById([FromQuery] RequestFoodContainRestaurant request)
        {
            var getFoodInResById = await _service.GetFoodInRestaurantById(request);

            if (getFoodInResById.Data == null)
            {
                return NotFound(getFoodInResById);
            }

            return Ok(getFoodInResById);
        }

        [HttpPost]
        [Route("CreateNewFood")]
        public async Task<IActionResult> CreateNewFood(RequestAddFood request)
        {
            var newFood = await _service.CreateFood(request);

            if (newFood.Data == null)
            {
                return BadRequest(newFood);
            }

            return Ok(newFood);
        }

        [HttpDelete]
        [Route("DeleteFood")]
        public async Task<IActionResult> CreateNewFood(RequestFoodContainRestaurant request)
        {
            var deleteFood = await _service.DeleteFood(request);

            if (deleteFood.Data == null)
            {
                return BadRequest(deleteFood);
            }

            return Ok(deleteFood);
        }

        [HttpPut]
        [Route("UpdateFood")]
        public async Task<IActionResult> UpdateFood(RequestUpdateFood request)
        {
            var updateFood = await _service.UpdateFood(request);

            if (updateFood.Data == null)
            {
                return BadRequest(updateFood);
            }

            return Ok(updateFood);
        }
    }
}