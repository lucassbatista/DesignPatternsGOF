using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Landvehicles
{
    internal class Car : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos os Passageiros, estamos prontos!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando o trajeto.");
        }
    }
}
