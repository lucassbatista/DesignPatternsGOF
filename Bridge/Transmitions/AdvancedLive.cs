using Bridge.Plataforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Transmitions
{
    internal class AdvancedLive : Live
    {
        public AdvancedLive(IPlataform plataform) : base(plataform)
        {
        }

        public void Subtitle() 
        {
            Console.WriteLine("Legendas ativadas");
        }

        public void Comments() 
        {
            Console.WriteLine("Comentários Liberados na live");
        }

        public void Record()
        { 
            Console.WriteLine("A Live esta sendo gravada!"); 
        }
    }
}
