using Parking.Application.Interface;
using Parking.Domain.Interface;
using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Application
{
    public class CarAppService : ICarAppService
    {
        private ICarDomainService _carDomainService { get; set; }

        public CarAppService(ICarDomainService carDomainService)
        {
            _carDomainService = carDomainService;
        }

        public bool Create(CarDto carDto)
        {
            return _carDomainService.Create(carDto);
        }

        public bool Update(CarDto carDto)
        {
            return _carDomainService.Update(carDto);
        }
    }
}
