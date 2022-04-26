using Bridge.Plataforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Transmitions
{
    internal class Live : ITransmition
    {
        protected IPlataform plataform;

        public Live(IPlataform plataform)
        {
            this.plataform = plataform;
        }

        public void Broadcasting()
        {
            Console.WriteLine($"Iniciando a transmição na {plataform}");
        }

        public void Result()
        {
            Console.WriteLine("Esta no ar");
        }
    }
}
