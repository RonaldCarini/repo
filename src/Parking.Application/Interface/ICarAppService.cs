using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Application.Interface
{
    public interface ICarAppService
    {
        bool Create(CarDto carDto);
        bool Update(CarDto carDto);
        bool Delete(int id);
        List<CarDto> GetAll();
        List<CarDto> GetAllWithDapper();
        CarDto GetById(int id);
    }
}
