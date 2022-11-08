using Microsoft.AspNetCore.Mvc;
using ShopeeApi.Dtos.Request;
using ShopeeApi.IRepository;
using ShopeeApi.IService;

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
        [Route("all-foods-without-restaurant")]
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
        [Route("total-index")]
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
        [Route("total-index-with-keywords/{keywords}")]
        public async Task<IActionResult> GetTotalIndexWithKeywords(string keywords)
        {
            var allIndexPage = await _repository.AllIndexPaginationWithKeywords(keywords);

            if (allIndexPage == 0)
            {
                return NotFound(allIndexPage);
            }

            return Ok(allIndexPage);
        }

        [HttpGet]
        [Route("food-with-index/{indexpage}")]
        public async Task<IActionResult> GetFoodWithIndex(int indexpage)
        {
            var allIndexPage = await _service.GetAllFoodPagination(indexpage);

            if (allIndexPage.Data == null)
            {
                return NotFound(allIndexPage);
            }

            return Ok(allIndexPage);
        }

        //Functions Test
        [HttpPost]
        [Route("total-index-with-restype")]
        public async Task<IActionResult> GetTotalIndexWithResType(RequestTotalIndexFoodWithResType request)
        {
            var allIndexPage = await _repository.AllIndexPaginationWithRestaurantType(request.RestaurantType);

            if (allIndexPage == 0)
            {
                return NotFound(allIndexPage);
            }

            return Ok(allIndexPage);
        }

        [HttpPost]
        [Route("food-with-index-and-restype")]
        public async Task<IActionResult> GetFoodWithIndexAndRestaurantType(RequestFoodWithIndexAndResType request)
        {
            var allIndexPage = await _service.GetAllFoodPaginationWithRestaurantType(request.indexpage, request.restype);

            if (allIndexPage.Data == null)
            {
                return NotFound(allIndexPage);
            }

            return Ok(allIndexPage);
        }

        //Functions Test


        [HttpPost]
        [Route("food-with-index-and-title")]
        public async Task<IActionResult> GetFoodWithIndexAndTitle(RequestFoodWithIndexAndTitle request)
        {
            var allIndexPage = await _service.GetAllFoodPaginationWithKeywords(request.indexpage, request.keywords);

            if (allIndexPage.Data == null)
            {
                return NotFound(allIndexPage);
            }

            return Ok(allIndexPage);
        }


        //End Function Test

        [HttpGet]
        [Route("all-foods-with-restaurant/{resId}")]
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
        [Route("food-with-its-id/{foodId}")]
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
        [Route("food-in-restaurant-by-id")]
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
        [Route("new-food")]
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
        [Route("delete-food")]
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
        [Route("update-food")]
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