using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Application.Interface
{
    public interface IReservationAppService
    {
        bool Post(ReservationDto reservationDto);
        bool UpdateStatus(int reservationId, int statusId);
        ResponseExtractDto GetExtract(int reservationId);
    }
}
