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
    public class CustomerController : ControllerBase
    {
        private ICustomerAppService _customerAppService { get; set; }

        public CustomerController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]CustomerDto customer)
        {
            if (_customerAppService.Create(customer))
                return Ok();
            else
                return BadRequest();
        }

        [HttpPut]
        public IActionResult Update([FromBody]CustomerDto customer)
        {
            if (_customerAppService.Update(customer))
                return Ok();
            else
                return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete([FromHeader]int id)
        {
            if (_customerAppService.Delete(id))
            {
                return Ok();
            }
            else
                return BadRequest();
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(_customerAppService.GetAll());
        }

        [HttpGet("getallwithdapper")]
        public IActionResult GetAllWithDapper()
        {
            return Ok(_customerAppService.GetAllWithDapper());
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            return Ok(_customerAppService.GetById(id));
        }
    }
}