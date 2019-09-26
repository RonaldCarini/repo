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
    public class AssociateController : ControllerBase
    {
        private IAssociateAppService _associateAppService { get; set; }
        public AssociateController(IAssociateAppService associateAppService)
        {
            _associateAppService = associateAppService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]AssociateDto associateDto)
        {
            if (_associateAppService.Create(associateDto))
                return Ok(associateDto);
            else
                return BadRequest();
        }
    }
}