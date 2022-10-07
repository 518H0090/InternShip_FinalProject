using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopeeApi.Service;

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
    }
}
