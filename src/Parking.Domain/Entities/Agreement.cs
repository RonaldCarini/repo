using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain
{
    public class Agreement
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int DiscountAmount { get; set; }
        public double DiscountPercentage { get; set; }
    }
}
