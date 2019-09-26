using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Interface
{
    public interface IReservationDomainService
    {
        bool Create(ReservationDto reservationDto);
        bool Update(ReservationDto reservationDto);
    }
}
