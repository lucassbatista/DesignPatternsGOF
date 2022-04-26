using AbstractFactory.App;
using AbstractFactory.Factories;
using System;
using System.ComponentModel.DataAnnotations;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var app = ConfigureApplication();

            app.StarRoute();
        }

        static Application ConfigureApplication()
        {
            Application app;
            ITransportFactory factory;
            string company = "Uber";

            switch (company)
            {
                case "Uber":
                    factory = new UberTransport();
                    break;
                case "NineNine":
                    factory = new NineNineTransport();
                    break;
                case "Lime":
                    factory = new LimeFactory();
                    break;
                default:
                    throw new ValidationException("Não foi configurado os transportes utilizados pela compania informada");
            }

            app = new Application(factory);

            return app;
        }
    }
}
