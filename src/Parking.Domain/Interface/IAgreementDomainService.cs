using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Interface
{
    public interface IAgreementDomainService
    {
        bool Create(AgreementDto agreementDto);
        bool Update(AgreementDto agreementDto);
        bool Delete(AgreementDto agreementDto);
    }
}
