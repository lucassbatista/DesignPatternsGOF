using Builder.Builders;
using Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    internal class Director
    {
        IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructSedan() 
        {
            builder.SetVehicleType(VehicleType.SEDAN);
            builder.SetEngine(new Engine(2000));
            builder.SetSeats(5);
            builder.SetTransmition(Transmition.AUTOMATIC);
        }

        public void ConstructTruck()
        {
            builder.SetVehicleType(VehicleType.TRUCK);  
            builder.SetEngine(new Engine(4000));
            builder.SetSeats(2);
            builder.SetTransmition(Transmition.MANUAL);
        }

        public void ConstructSUV()
        {
            builder.SetVehicleType(VehicleType.PICKUPTRUCK);
            builder.SetEngine(new Engine(2600));
            builder.SetSeats(5);
            builder.SetTransmition(Transmition.AUTOMATIC);
            builder.SetAirbags(4);
        }
    }
}
