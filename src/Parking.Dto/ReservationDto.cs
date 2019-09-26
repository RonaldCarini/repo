using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto
{
    public class ReservationDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public CarDto Car { get; set; }
        public int? AssociateId { get; set; }
        public AssociateDto Associate { get; set; }
        public int? CustomerId { get; set; }
        public CustomerDto Customer { get; set; }
        public int Type { get; set; } // Diaria, Pernoite, Hora
        public int Status { get; set; } // Ativa, Finalizada
        public DateTime StartDate { get; set; }
        public DateTime FinalDate { get; set; }
    }
}
