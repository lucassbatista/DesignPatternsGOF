using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Plataforms
{
    internal interface IPlataform
    {
        void ConfigureRMTP();

        void AuthToken();
    }
}
