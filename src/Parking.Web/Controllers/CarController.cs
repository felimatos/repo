using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parking.Application.Interface;
using Parking.Domain;
using Parking.Dto;

namespace Parking.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        public ICarAppService _carAppService { get; set; }

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
    }
}