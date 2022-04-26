using FactoryMethod.Factories;
using System;
using System.ComponentModel.DataAnnotations;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TransportFactory factory = new TransportFactory(args[0]);
                Transport transport = factory.CreateTransport();

                if (transport != null)
                    transport.StartTransport();
            }
            catch (ValidationException vEx)
            {
                Console.WriteLine(vEx.Message);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
