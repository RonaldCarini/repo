using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Infra.Interface
{
    public interface IRateReadRepository
    {
        List<RateDto> GetAll();

        RateDto GetById(int id);

        List<RateDto> GetAllWithDapper();
    }
}
