using System.ComponentModel.DataAnnotations;

namespace FactoryMethod.Factories
{
    internal class TransportFactory
    {

        private string _transportType;
        public TransportFactory(string transportType)
        {
            this._transportType = transportType;
        }

        public Transport CreateTransport()
        {
            switch (_transportType.ToUpper())
            {
                case "UBER":
                    return new CarTransport();

                case "UBERLOG":
                    return new MotorcycleTransport();

                case "UBEREATS":
                    return new BicycleTransport();
                default:
                    throw new ValidationException("O Tipo de transporte solicitado não existe!");
            }
        }
    }
}
