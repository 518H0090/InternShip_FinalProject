using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopeeApi.Dtos;
using ShopeeApi.Repository;
using ShopeeApi.Service;

namespace ShopeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodRecordController : ControllerBase
    {
        private readonly IRecordRepository _repository;
        private readonly IRecordService _service;

        public FoodRecordController(IRecordRepository repository, IRecordService service)
        {
            _repository = repository;
            _service = service;
        }

        [HttpGet]
        [Route("GetTotalPriceBill/{username}")]
        public async Task<IActionResult> GetTotalPriceBill(string username)
        {
            return Ok(await _repository.TotalPriceRecord(username));
        }

        [HttpGet]
        [Route("GetAllRecord/{username}")]
        public async Task<IActionResult> GetAllRecordFollowUser(string username)
        {
            var getAllRecord = await _service.GetAllRecordFollowUsername(username);

            if (getAllRecord.Data == null)
            {
                return BadRequest(getAllRecord);
            }

            return Ok(getAllRecord);
        }

        [HttpPost]
        [Route("AddNewItemInShoppingCart/{username}")]
        public async Task<IActionResult> AddNewItemInShoppingCart(RequestAddFoodRecord request, string username)
        {
            var getAllRecord = await _service.NewRecord(request,username);

            if (getAllRecord.Data == null)
            {
                return BadRequest(getAllRecord);
            }

            return Ok(getAllRecord);
        }

        [HttpPost]
        [Route("DeleteItemInShoppingCart")]
        public async Task<IActionResult> DeleteItemInShoppingCart(RequestDeleteFoodRecord request)
        {
            var deleteRecord = await _service.DeleteRecord(request);

            if (deleteRecord.Data == null)
            {
                return BadRequest(deleteRecord);
            }

            return Ok(deleteRecord);
        }


    }
}
