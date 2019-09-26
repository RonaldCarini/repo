using System.Collections.Generic;
using Parking.Application.Interface;
using Parking.Domain.Interface;
using Parking.Dto;
using Parking.Infra;
using Parking.Infra.Interface;

namespace Parking.Application
{
    public class ParkingAppService : IParkingAppService
    {
        private IParkingDomainService _parkingDomainService { get; set; }
        private IParkingReadRepository _parkingReadRepository { get; set; }

        public ParkingAppService(IParkingDomainService parkingDomainService,
                                IParkingReadRepository parkingReadRepository)
        {
            _parkingDomainService = parkingDomainService;
            _parkingReadRepository = parkingReadRepository;
        }

        public bool Create(ParkingDto parkingDto)
        {
            return _parkingDomainService.Create(parkingDto);
        }

        public bool Update(ParkingDto parkingDto)
        {
            return _parkingDomainService.Update(parkingDto);
        }

        public bool Delete(int id)
        {            
            var parkingDto = _parkingReadRepository.GetById(id);
            return _parkingDomainService.Delete(parkingDto);
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
