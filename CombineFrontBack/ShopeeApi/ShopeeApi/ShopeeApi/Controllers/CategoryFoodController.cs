using Microsoft.AspNetCore.Mvc;
using ShopeeApi.Dtos.Request;
using ShopeeApi.IService;

namespace ShopeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryFoodController : ControllerBase
    {
        private readonly ICategoryFoodService _service;

        public CategoryFoodController(ICategoryFoodService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("all-relations")]
        public async Task<IActionResult> GetAllRelation()
        {
            var getAllRelate = await _service.GetAllRelation();

            if (getAllRelate.Data == null)
            {
                return NotFound(getAllRelate);
            }

            return Ok(getAllRelate);
        }

        [HttpGet]
        [Route("all-categories-combine-food/{resID}")]
        public async Task<IActionResult> GetAllCategoryCombineFood(int resID)
        {
            var getAllRelate = await _service.GetAllCategorywithRestaurantIdCombineFood(resID);

            return Ok(getAllRelate);
        }

        [HttpGet]
        [Route("all-food-combine-category/{resID}")]
        public async Task<IActionResult> GetAllFoodCombineCategory(int resID)
        {
            var getAllRelate = await _service.GetAllFoodwithRestaurantIdCombineCategory(resID);

            return Ok(getAllRelate);
        }

        [HttpGet]
        [Route("food-combine-category")]
        public async Task<IActionResult> GetFoodCombineCategory([FromQuery] RequestFoodCombineCategory request)
        {
            var getRelate = await _service.GetFoodwithRestaurantIdCombineCategory(request);

            return Ok(getRelate);
        }

        [HttpGet]
        [Route("category-combine-food")]
        public async Task<IActionResult> GetCategoryCombineFood([FromQuery] RequestCategoryCombineFood request)
        {
            var getRelate = await _service.GetCategorywithRestaurantIdCombineFood(request);

            return Ok(getRelate);
        }

        [HttpPost]
        [Route("new-relationship")]
        public async Task<IActionResult> NewRelationship(int resId, RequestCategoryFood request)
        {
            var newRelationship = await _service.ConnectFoodTag(resId, request);

            if (newRelationship.Data == null)
            {
                return BadRequest(newRelationship);
            }

            return Ok(newRelationship);
        }

        [HttpDelete]
        [Route("delete-relationship")]
        public async Task<IActionResult> DeleteRelationship(int resId, RequestCategoryFood request)
        {
            var deleteRelationship = await _service.DeleteRelationFoodTag(resId, request);

            if (deleteRelationship.Data == null)
            {
                return BadRequest(deleteRelationship);
            }

            return Ok(deleteRelationship);
        }
    }
}