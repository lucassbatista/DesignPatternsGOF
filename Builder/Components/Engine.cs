using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Components
{
    internal class Engine
    {
        public Engine(int power)
        {
            this.Power = power;
        }

        public int Power { get; private set; }
    }
}
