using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Application.Interface
{
    public interface IRateAppService
    {
        bool Create(RateDto rateDto);
        bool Update(RateDto rateDto);
        bool Delete(int id);
        List<RateDto> GetAll();
        List<RateDto> GetAllWithDapper();
        RateDto GetById(int id);
    }
}
