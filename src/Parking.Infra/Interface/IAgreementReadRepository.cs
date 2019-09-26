using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Infra.Interface
{
    public interface IAgreementReadRepository
    {
        List<AgreementDto> GetAll();

        AgreementDto GetById(int id);

        List<AgreementDto> GetAllWithDapper();
    }
}
