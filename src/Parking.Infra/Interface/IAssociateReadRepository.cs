using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Infra.Interface
{
    public interface IAssociateReadRepository
    {
        List<AssociateDto> GetAll();
        AssociateDto GetById(int id);
    }
}
