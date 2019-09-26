using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Interface
{
    public interface IAssociateDomainService
    {
        bool Create(AssociateDto associateDto);
        bool Update(AssociateDto associateDto);
        bool Delete(AssociateDto associateDto);
    }
}
