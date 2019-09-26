
using Parking.Application.Interface;
using Parking.Domain;
using Parking.Domain.Extensions;
using Parking.Domain.Interface;
using Parking.Dto;
using Parking.Infra;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Application
{
    public class ParkingAppService : IParkingAppService
    {
        private readonly IParkingDomainService _parkingDomainService;
        private readonly IParkingReadRepository _parkingReadRepository;

        public ParkingAppService(IParkingDomainService parkingDomainService, IParkingReadRepository parkingReadRepository)
        {
            _parkingDomainService = parkingDomainService;
            _parkingReadRepository = parkingReadRepository;
        }
        public bool Create(ParkingDto parking)
        {
            return _parkingDomainService.Create(parking);
        }
        public bool Delete(int id)
        {
            var entity = _parkingReadRepository.GetById(id);

            return _parkingDomainService.Delete(entity);
        }
        public List<ParkingDto> GetAll()
        {
            return _parkingReadRepository.GetAll();
        }
        public List<ParkingDto> GetAllWithDapper()
        {
            return _parkingReadRepository.GetAllWithDapper();
        }
        public ParkingDto GetById(int id)
        {
            return _parkingReadRepository.GetById(id);
        }

    }
}
