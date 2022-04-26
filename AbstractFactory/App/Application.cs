using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.Landvehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.App
{
    internal class Application
    {
        private IAircraft aircraft = null;
        private ILandVehicle vehicle = null;

        public Application(ITransportFactory factory)
        {
            if (factory is ITransportAircraftFactory)
                aircraft = (factory as ITransportAircraftFactory).CreateTransportAircraft();

            if (factory is ITransportLandVehicleFactory)
                vehicle = (factory as ITransportLandVehicleFactory).CreateTransportVehicle();
        }

        public void StarRoute()
        {
            if (aircraft != null)
                aircraft.StartRoute();

            if (vehicle != null)
                vehicle.StartRoute();
        }
    }
}
