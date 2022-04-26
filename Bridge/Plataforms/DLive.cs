using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Plataforms
{
    internal class DLive : IPlataform
    {
        public DLive()
        {
            ConfigureRMTP();
        }

        public void AuthToken()
        {
            Console.WriteLine("DLive Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("configurando servidor RMTP");
        }
    }
}
