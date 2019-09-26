using Parking.Application.Interface;
using Parking.Domain.Interface;
using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Application
{
    public class ReservationAppService : IReservationAppService
    {
        private IReservationDomainService _reservationDomainService { get; set; }

        public ReservationAppService(IReservationDomainService reservationDomainService)
        {
            _reservationDomainService = reservationDomainService;
        }

        public bool Create(ReservationDto reservationDto)
        {
            return _reservationDomainService.Create(reservationDto);
        }

        public bool Update(ReservationDto reservationDto)
        {
            return _reservationDomainService.Update(reservationDto);
        }
    }
}
