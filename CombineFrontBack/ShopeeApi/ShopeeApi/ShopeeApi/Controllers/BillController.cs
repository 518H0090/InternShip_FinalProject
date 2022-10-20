﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopeeApi.Dtos;
using ShopeeApi.Service;

namespace ShopeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IBillService _service;

        public BillController(IBillService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetAllBills")]
        public async Task<IActionResult> GetAllBills()
        {
            var getAllBills = await _service.GetAllBill();

            if (getAllBills.Data == null)
            {
                return BadRequest(getAllBills);
            }

            return Ok(getAllBills);
        }

        [HttpGet]
        [Route("GetAllBillFollowUsername")]
        public async Task<IActionResult> GetAllBillFollowUsername(string username)
        {
            var getAllBills = await _service.GetAllBillFollowUsername(username);

            if (getAllBills.Data == null)
            {
                return BadRequest(getAllBills);
            }

            return Ok(getAllBills);
        }

        [HttpPost]
        [Route("CreateNewBill")]
        public async Task<IActionResult> CreateNewBill(RequestAddBill request)
        {
            var newBill = await _service.CreateNewBill(request);

            if (newBill.Data == null)
            {
                return BadRequest(newBill);
            }

            return Ok(newBill);
        }
    }
}
