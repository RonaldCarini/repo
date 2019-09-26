using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string LegalEntity { get; set; }
    }
}
