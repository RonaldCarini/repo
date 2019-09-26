using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Infra.Interface
{
    public interface IReservationReadRepository
    {
        ReservationDto GetById(int id);
    }
}
