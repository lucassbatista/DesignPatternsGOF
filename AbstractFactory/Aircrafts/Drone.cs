using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    internal class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, ventos OK");
        }

        public void GetCargo()
        {
            Console.WriteLine("Encomenda capturada!");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem ...");
        }
    }
}
