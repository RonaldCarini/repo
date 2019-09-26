using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto
{
    public class ResponseExtractDto
    {
        public int ReservationId { get; set; }
        public string ClientName { get; set; }
        public decimal Amount { get; set; }
        public string Period { get; set; }
        public string RateDescription { get; set; }
        public string Status { get; set; }
    }
}
