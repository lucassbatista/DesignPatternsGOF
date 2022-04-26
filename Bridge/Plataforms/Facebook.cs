using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Plataforms
{
    internal class Facebook : IPlataform
    {
        public Facebook()
        {
            ConfigureRMTP();
        }

        public void AuthToken()
        {
            Console.WriteLine("Facebook Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("configurando servidor RMTP");
        }
    }
}
