using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto
{
    public class AssociateDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public CustomerDto Customer { get; set; }
        public AgreementDto Agreement { get; set; }
        public RateDto Rate { get; set; }
    }
}
