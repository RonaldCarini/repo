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
    public class CarController : ControllerBase
    {
        private ICarAppService _carAppService { get; set; }
        public CarController(ICarAppService carAppService)
        {
            _carAppService = carAppService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]CarDto car)
        {
            if (_carAppService.Create(car))
                return Ok();
            else
                return BadRequest();
        }

        [HttpPut]
        public IActionResult Update([FromBody]CarDto car)
        {
            if (_carAppService.Update(car))
                return Ok();
            else
                return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete([FromHeader]int id)
        {
            if (_carAppService.Delete(id))
            {
                return Ok();
            }
            else
                return BadRequest();
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(_carAppService.GetAll());
        }

        [HttpGet("getallwithdapper")]
        public IActionResult GetAllWithDapper()
        {
            return Ok(_carAppService.GetAllWithDapper());
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            return Ok(_carAppService.GetById(id));
        }
    }
}