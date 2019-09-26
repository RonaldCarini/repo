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
    public class ParkingController : ControllerBase
    {
        private IParkingAppService _parkingAppService { get; set; }

        public ParkingController(IParkingAppService parkingAppService)
        {
            _parkingAppService = parkingAppService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]ParkingDto parking)
        {
            if (_parkingAppService.Create(parking))
                return Ok();
            else
                return BadRequest();
        }

        [HttpPut]
        public IActionResult Update([FromBody]ParkingDto parking)
        {
            if (_parkingAppService.Update(parking))
                return Ok();
            else
                return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete([FromHeader]int id)
        {
            if (_parkingAppService.Delete(id))
            {
                return Ok();
            }
            else
                return BadRequest();
        }
        
        [ResponseCache(CacheProfileName = "GetAllParking", Duration = 3600 )]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(_parkingAppService.GetAll());
        }

        [HttpGet("getallwithdapper")]
        public IActionResult GetAllWithDapper()
        {
            return Ok(_parkingAppService.GetAllWithDapper());
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            return Ok(_parkingAppService.GetById(id));
        }

    }
}