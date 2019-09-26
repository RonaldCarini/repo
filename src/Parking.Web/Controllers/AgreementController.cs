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
    public class AgreementController : ControllerBase
    {
        private IAgreementAppService _agreementAppService { get; set; }
        public AgreementController(IAgreementAppService agreementAppService)
        {
            _agreementAppService = agreementAppService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]AgreementDto agreement)
        {
            if (_agreementAppService.Create(agreement))
                return Ok();
            else
                return BadRequest();
        }

        [HttpPut]
        public IActionResult Update([FromBody]AgreementDto agreement)
        {
            if (_agreementAppService.Update(agreement))
                return Ok();
            else
                return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete([FromHeader]int id)
        {
            if (_agreementAppService.Delete(id))
            {
                return Ok();
            }
            else
                return BadRequest();
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(_agreementAppService.GetAll());
        }

        [HttpGet("getallwithdapper")]
        public IActionResult GetAllWithDapper()
        {
            return Ok(_agreementAppService.GetAllWithDapper());
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            return Ok(_agreementAppService.GetById(id));
        }
    }
}