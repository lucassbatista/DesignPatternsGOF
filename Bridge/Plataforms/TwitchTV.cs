using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Plataforms
{
    internal class TwitchTV : IPlataform
    {
        public TwitchTV()
        {
            ConfigureRMTP();
        }

        public void AuthToken()
        {
            Console.WriteLine("TwitchTV Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("configurando servidor RMTP");
        }
    }
}
