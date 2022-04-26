using FactoryMethod.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    internal class CarTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Car();
        }
    }
}
