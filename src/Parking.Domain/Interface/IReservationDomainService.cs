using System;
using System.Collections.Generic;
using System.Text;
using Parking.Dto;

namespace Parking.Domain.Interface
{
    public interface IReservationDomainService
    {
        bool Post(ReservationDto reservationDto);
        bool UpdateStatus(ReservationDto reservationDto, int statusId);
    }
}
