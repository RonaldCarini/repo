using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Interface
{
    public interface IRateDomainService
    {
        bool Create(RateDto rateDto);
        bool Update(RateDto rateDto);
        bool Delete(RateDto rateDto);
        decimal GenerateAmountByType(RateDto rate, int type);
    }
}
