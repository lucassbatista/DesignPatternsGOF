using Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Products
{
    internal class Vehicle
    {

        public VehicleType VehicleType { get; set; }

        public int Seats { get; set; }

        public Engine Engine { get; set; }

        public Transmition Transmition { get; set; }

        public int Airbags { get; set; }   
    }
}
