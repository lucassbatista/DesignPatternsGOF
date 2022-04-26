using AbstractFactory.Aircrafts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal interface ITransportAircraftFactory : ITransportFactory
    {
        IAircraft CreateTransportAircraft();
    }
}
