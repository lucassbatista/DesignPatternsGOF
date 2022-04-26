using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Plataforms
{
    internal class Youtube : IPlataform
    {
        public Youtube()
        {
            ConfigureRMTP();
        }

        public void AuthToken()
        {
            Console.WriteLine("Youtube Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("configurando servidor RMTP");
        }
    }
}
