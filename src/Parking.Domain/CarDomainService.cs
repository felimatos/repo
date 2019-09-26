using Parking.Domain.Context;
using Parking.Dto;

namespace Parking.Domain.Interface
{
    class CarDomainService : ICarDomainService
    {
        private ParkingDataContext _context { get; set; }
        public CarDomainService(ParkingDataContext context)
        {
            _context = context;
        }
        public bool Create(CarDto carDto)
        {            
            try
            {
                _context.Car.Add(carDto);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Update(CarDto carDto)
        {         
            try
            {
                _context.Car.Update(carDto);
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
