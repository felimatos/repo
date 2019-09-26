using Parking.Domain.Context;
using Parking.Domain.Interface;
using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain
{
    class ReservationDomainService : IReservationDomainService
    {
        private ParkingDataContext _context { get; set; }
        public ReservationDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Create(ReservationDto reservationDto)
        {
            try
            {
                _context.Reservation.Add(reservationDto);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool Update(ReservationDto reservationDto)
        {
            try
            {
                _context.Reservation.Update(reservationDto);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
