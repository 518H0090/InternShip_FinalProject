using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopeeApi.Dtos.Request;
using ShopeeApi.IRepository;
using ShopeeApi.IService;

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
        [Route("total-bill/{username}")]
        public async Task<IActionResult> GetTotalPriceBill(string username)
        {
            return Ok(await _repository.TotalPriceRecord(username));
        }

        [HttpGet]
        [Route("count-number-record-follow-user/{username}")]
        public async Task<IActionResult> GetCountNumberRecordFollowUserName(string username)
        {
            return Ok(await _repository.CountNumberRecord(username));
        }

        [HttpGet]
        [Route("all-record-follow-user/{username}")]
        public async Task<IActionResult> GetAllRecordFollowUser(string username)
        {
            var getAllRecord = await _service.GetAllRecordFollowUsername(username);

            if (getAllRecord.Data == null)
            {
                return BadRequest(getAllRecord);
            }

            return Ok(getAllRecord);
        }

        [HttpGet]
        [Route("top-6-record/{username}")]
        public async Task<IActionResult> GetTop6Record(string username)
        {
            var getTop6Record = await _service.GetTop6RecordFollowUsername(username);

            if (getTop6Record.Data == null)
            {
                return BadRequest(getTop6Record);
            }

            return Ok(getTop6Record);
        }

        [HttpPost]
        [Route("new-item/{username}")]
        public async Task<IActionResult> AddNewItemInShoppingCart(RequestAddFoodRecord request, string username)
        {
            var getAllRecord = await _service.NewRecord(request,username);

            if (getAllRecord.Data == null)
            {
                return BadRequest(getAllRecord);
            }

            return Ok(getAllRecord);
        }

        [HttpDelete]
        [Route("remove-item")]
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
