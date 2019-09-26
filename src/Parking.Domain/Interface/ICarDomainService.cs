using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Interface
{
    public interface ICarDomainService
    {
        bool Create(CarDto carDto);
        bool Update(CarDto carDto);
        bool Delete(CarDto carDto);
    }
}
