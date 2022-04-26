using Builder.Components;
using Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    internal interface IBuilder
    {
        void Reset();

        Vehicle GetVehicle();

        void SetSeats(int seats);

        void SetEngine(Engine engine);

        void SetTransmition(Transmition transmition);

        void SetVehicleType(VehicleType vehicleType);

        void SetAirbags(int airbags);
    }
}
