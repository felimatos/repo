using System;
using System.Collections.Generic;
using System.Text;
using Parking.Domain.Context;
using Parking.Dto;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Parking.Domain.Extensions;
using Dapper;

namespace Parking.Infra
{
    public class ParkingReadRepository : IParkingReadRepository
    {
        private ParkingDataContext _context { get; set; }
        public ParkingReadRepository(ParkingDataContext context)
        {
            _context = context;
        }
        public List<ParkingDto> GetAll()
        {
            return (from parking in _context.Parking
                    select parking.EntityToDto()).ToList();
        }
        public ParkingDto GetById(int id)
        {
            return _context.Parking
                .Where(x => x.Id == id)
                .Select(x => x.EntityToDto()).FirstOrDefault();
        }

        public List<ParkingDto> GetAllWithDapper()
        {
            var ret = new List<ParkingDto>();

            using (var connection = _context.Database.GetDbConnection())
            {
                ret = connection.Query<ParkingDto>("SELECT ID, DESCRIPTION, DOCUMENT, ADDRESS, PHONE FROM PARKING").ToList();
            }
            return ret;
        }
    }
}
