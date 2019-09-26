using Parking.Domain.Context;
using Parking.Domain.Extensions;
using Parking.Dto;
using System.Collections.Generic;
using System.Linq;

namespace Parking.Domain.Interface
{
    class ParkingDomainService : IParkingDomainService
    {
        private ParkingDataContext _context { get; set; }

        public ParkingDomainService(ParkingDataContext context)
        {
            _context = context;
        }
        public bool Create(ParkingDto parkingDto)
        {
            //var executed = false;
            try
            {
                _context.Parking.Add(parkingDto.DtoToEntity());
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Delete(ParkingDto parkingDto)
        {
            try
            {
                _context.Parking.Remove(parkingDto.DtoToEntity());
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(ParkingDto parkingDto)
        {
            try
            {
                _context.Parking.Update(parkingDto.DtoToEntity());
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public IList<ParkingDto> GetAll()
        {
            var listaDto = new List<ParkingDto>();

            foreach (var item in _context.Parking.ToList())
            {
                listaDto.Add(item.EntityToDto());
            }
            return listaDto;
        }

    }
}
