using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain
{
    public class Car
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}
