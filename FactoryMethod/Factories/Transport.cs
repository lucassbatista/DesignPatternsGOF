using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    internal abstract class Transport
    {
        internal void StartTransport()
        {
            IVehicle vehicle = CreateTransport();
            vehicle.StartRoute();
        }

        protected abstract IVehicle CreateTransport();
    }
}
