using Microsoft.AspNetCore.Mvc;
using Parking.Application.Interface;
using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking.Web.Controllers
{
    public class ReservationController : ControllerBase
    {
        public IReservationAppService _reservationAppService { get; set; }
        public ReservationController(IReservationAppService reservationAppService)
        {
            _reservationAppService = reservationAppService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]ReservationDto parking)
        {
            if (_reservationAppService.Create(parking))
                return Ok();
            else
                return BadRequest();
        }
    }
}
