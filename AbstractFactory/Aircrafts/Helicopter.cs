using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    internal class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, ventos a 25km, ventos OK");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros a bordo, voo autorizado! Ligando a helices ...");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem");
        }
    }
}
