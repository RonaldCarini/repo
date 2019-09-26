using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Application.Interface
{
    public interface IAgreementAppService
    {
        bool Create(AgreementDto agreementDto);
        bool Update(AgreementDto agreementDto);
        bool Delete(int id);
        List<AgreementDto> GetAll();
        List<AgreementDto> GetAllWithDapper();
        AgreementDto GetById(int id);
    }
}
