using Parking.Application.Interface;
using Parking.Domain;
using Parking.Domain.Interface;
using Parking.Dto;
using Parking.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Application
{
    public class CarAppService : ICarAppService
    {
        private ICarDomainService _carDomainService { get; set; }
        private ICarReadRepository _carReadRepository { get; set; }

        public CarAppService(ICarDomainService carDomainService,
                             ICarReadRepository carReadRepository)
        {
            _carDomainService = carDomainService;
            _carReadRepository = carReadRepository;
        }
        public bool Create(CarDto carDto)
        {
            return _carDomainService.Create(carDto);
        }

        public bool Delete(int id)
        {
            var carDto = _carReadRepository.GetById(id);
            return _carDomainService.Delete(carDto);
        }

        public bool Update(CarDto carDto)
        {
            return _carDomainService.Update(carDto);
        }

        public List<CarDto> GetAll()
        {
            return _carReadRepository.GetAll();
        }

        public List<CarDto> GetAllWithDapper()
        {
            return _carReadRepository.GetAllWithDapper();
        }

        public CarDto GetById(int id)
        {
            return _carReadRepository.GetById(id);
        }
    }
}
