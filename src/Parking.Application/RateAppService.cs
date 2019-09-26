using Parking.Application.Interface;
using Parking.Domain.Interface;
using Parking.Dto;
using Parking.Infra.Interface;
using System.Collections.Generic;

namespace Parking.Application
{
    public class RateAppService : IRateAppService
    {
        private IRateDomainService _rateDomainService { get; set; }
        private IRateReadRepository _rateReadRepository { get; set; }

        public RateAppService(IRateDomainService rateDomainService,
                              IRateReadRepository rateReadRepository)
        {
            _rateDomainService = rateDomainService;
            _rateReadRepository = rateReadRepository;
        }

        public bool Create(RateDto rateDto)
        {
            return _rateDomainService.Create(rateDto);
        }

        public bool Delete(int id)
        {
            var rateDto = _rateReadRepository.GetById(id);
            return _rateDomainService.Delete(rateDto);
        }

        public bool Update(RateDto rateDto)
        {
            return _rateDomainService.Update(rateDto);
        }

        public List<RateDto> GetAll()
        {
            return _rateReadRepository.GetAll();
        }

        public List<RateDto> GetAllWithDapper()
        {
            return _rateReadRepository.GetAllWithDapper();
        }

        public RateDto GetById(int id)
        {
            return _rateReadRepository.GetById(id);
        }
    }
}
