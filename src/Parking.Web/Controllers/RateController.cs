using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parking.Application.Interface;
using Parking.Dto;

namespace Parking.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RateController : ControllerBase
    {
        private IRateAppService _rateAppService { get; set; }
        public RateController(IRateAppService rateAppService)
        {
            _rateAppService = rateAppService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]RateDto rate)
        {
            if (_rateAppService.Create(rate))
                return Ok();
            else
                return BadRequest();
        }

        [HttpPut]
        public IActionResult Update([FromBody]RateDto rate)
        {
            if (_rateAppService.Update(rate))
                return Ok();
            else
                return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete([FromHeader]int id)
        {
            if (_rateAppService.Delete(id))
            {
                return Ok();
            }
            else
                return BadRequest();
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(_rateAppService.GetAll());
        }

        [HttpGet("getallwithdapper")]
        public IActionResult GetAllWithDapper()
        {
            return Ok(_rateAppService.GetAllWithDapper());
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            return Ok(_rateAppService.GetById(id));
        }
    }
}