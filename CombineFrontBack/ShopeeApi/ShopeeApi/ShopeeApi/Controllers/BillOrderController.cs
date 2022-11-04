﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopeeApi.Dtos;
using ShopeeApi.Service;

namespace ShopeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillOrderController : ControllerBase
    {
        private readonly IBillOrderService _service;

        public BillOrderController(IBillOrderService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("all-bill-order")]
        public async Task<IActionResult> GetAllBillOrder([FromHeader(Name = "username")] string username)
        {
            var getAllBill = await _service.GetAllBillOrder(username);

            if (getAllBill.Data == null)
            {
                return BadRequest(getAllBill);
            }

            return Ok(getAllBill);
        }

        [HttpPost]
        [Route("new-bill-order")]
        public async Task<IActionResult> CreateBillOrder(RequestAddBillOrder request)
        {
            var newBill = await _service.CreateBillOrder(request);

            if (newBill.Data == null)
            {
                return BadRequest(newBill);
            }

            return Ok(newBill);
        }

    }
}
