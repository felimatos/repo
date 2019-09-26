using Parking.Dto;

namespace Parking.Application.Interface
{
    public interface IReservationAppService
    {
        bool Create(ReservationDto reservationDto);
        bool Update(ReservationDto reservationDto);
    }
}