using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain
{
    public class Associate
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Customer Customer { get; set; }
        public Agreement Agreement { get; set; }        
    }
}
