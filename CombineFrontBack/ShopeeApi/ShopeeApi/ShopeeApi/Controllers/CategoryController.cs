using Microsoft.AspNetCore.Mvc;
using ShopeeApi.Dtos.Request;
using ShopeeApi.IService;

namespace ShopeeApi.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("all-categories-without-restaurant")]
        public async Task<IActionResult> GetAllCategoriesWithoutRestaurant()
        {
            var getFullCategories = await _service.GetFullCategories();

            if (getFullCategories.Data == null)
            {
                return BadRequest(getFullCategories);
            }

            return Ok(getFullCategories);
        }

        [HttpGet]
        [Route("all-categories-with-restaurantid/{ResId}")]
        public async Task<IActionResult> GetAllCategoriesWithRestaurant(int ResId)
        {
            var getAllCategories = await _service.GetAllCategories(ResId);

            if (getAllCategories.Data == null)
            {
                return BadRequest(getAllCategories);
            }

            return Ok(getAllCategories);
        }

        [HttpPost]
        [Route("category-with-id")]
        public async Task<IActionResult> GetCategoryWithId([FromBody] RequestCategoryById request)
        {
            var GetCategoryById = await _service.GetCategoryById(request);

            if (GetCategoryById.Data == null)
            {
                return BadRequest(GetCategoryById);
            }

            return Ok(GetCategoryById);
        }

        [HttpPost]
        [Route("category-with-tag")]
        public async Task<IActionResult> GetCategoryWithTag([FromBody] RequestCategoryByTag request)
        {
            var GetCategoryByTag = await _service.GetCategoryByTag(request);

            if (GetCategoryByTag.Data == null)
            {
                return BadRequest(GetCategoryByTag);
            }

            return Ok(GetCategoryByTag);
        }

        [HttpPost]
        [Route("new-category-in-restaurant")]
        public async Task<IActionResult> NewCategoryInRestaurant([FromBody] RequestAddCategory request)
        {
            var newCategory = await _service.CreateCategory(request);

            if (newCategory.Data == null)
            {
                return BadRequest(newCategory);
            }

            return Ok(newCategory);
        }

        [HttpDelete]
        [Route("delete-category-in-restaurant")]
        public async Task<IActionResult> DeleteCategoryInRestaurant([FromBody] RequestDeleteCategory request)
        {
            var deleteCategory = await _service.DeleteCategory(request);

            if (deleteCategory.Data == null)
            {
                return BadRequest(deleteCategory);
            }

            return Ok(deleteCategory);
        }

        [HttpPut]
        [Route("update-category")]
        public async Task<IActionResult> UpdateCategory([FromBody] RequestEditCategory request)
        {
            var updateCategory = await _service.UpdateCategory(request);

            if (updateCategory.Data == null)
            {
                return BadRequest(updateCategory);
            }

            return Ok(updateCategory);
        }
    }
}