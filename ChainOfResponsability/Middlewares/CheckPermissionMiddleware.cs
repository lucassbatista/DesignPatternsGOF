using ChainOfResponsability.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Middlewares
{
    internal class CheckPermissionMiddleware : Middleware
    {
        private Server server;

        public CheckPermissionMiddleware(Server server)
        {
            this.server = server;
        }

        public override bool Check(string email, string password)
        {
            if (server.IsAdmin(email))
                Console.WriteLine("Seja bem-vindo Admin");
            else
                Console.WriteLine("Seja bem-vindo!");

            return CheckNext(email, password);
        }
    }
}
