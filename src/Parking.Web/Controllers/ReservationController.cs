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
    public class ReservationController : ControllerBase
    {
        private IReservationAppService _reservationAppService { get; set; }
        public ReservationController(IReservationAppService reservationAppService)
        {
            _reservationAppService = reservationAppService;
        }

        [HttpPost]
        public IActionResult Post([FromBody]ReservationDto reservationDto)
        {
            if (_reservationAppService.Post(reservationDto))
                return Ok(reservationDto);
            else
                return BadRequest();
        }

        [HttpPatch]
        public IActionResult UpdateStatus(int reservationId, int statusId)
        {
            return Ok(_reservationAppService.UpdateStatus(reservationId, statusId));              
        }

        [HttpGet]
        public IActionResult GetExtract(int reservationId)
        {
            return Ok(_reservationAppService.GetExtract(reservationId));
        }

    }
}