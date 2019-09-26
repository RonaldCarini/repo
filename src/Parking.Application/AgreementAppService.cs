using System.Collections.Generic;
using Parking.Application.Interface;
using Parking.Domain.Interface;
using Parking.Dto;
using Parking.Infra.Interface;

namespace Parking.Application
{
    public class AgreementAppService : IAgreementAppService
    {
        private IAgreementDomainService _agreementDomainService { get; set; }
        private IAgreementReadRepository _agreementReadRepository { get; set; }
        public AgreementAppService(IAgreementDomainService agreementDomainService,
                                   IAgreementReadRepository agreementReadRepository)
        {
            _agreementDomainService = agreementDomainService;
            _agreementReadRepository = agreementReadRepository;
        }

        public bool Create(AgreementDto agreementDto)
        {
            return _agreementDomainService.Create(agreementDto);
        }

        public bool Delete(int id)
        {
            var agreementDto = _agreementReadRepository.GetById(id);
            return _agreementDomainService.Delete(agreementDto);
        }

        public bool Update(AgreementDto agreementDto)
        {
            return _agreementDomainService.Update(agreementDto);
        }

        public List<AgreementDto> GetAll()
        {
            return _agreementReadRepository.GetAll();
        }

        public List<AgreementDto> GetAllWithDapper()
        {
            return _agreementReadRepository.GetAllWithDapper();
        }

        public AgreementDto GetById(int id)
        {
            return _agreementReadRepository.GetById(id);
        }
    }
}
