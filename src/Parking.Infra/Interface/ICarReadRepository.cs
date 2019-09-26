using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Infra.Interface
{
    public interface ICarReadRepository
    {
        List<CarDto> GetAll();

        CarDto GetById(int id);

        List<CarDto> GetAllWithDapper();
    }
}
