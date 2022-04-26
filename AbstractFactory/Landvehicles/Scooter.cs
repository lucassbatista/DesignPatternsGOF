using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Landvehicles
{
    internal class Scooter : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a entrega.");
        }
    }
}
