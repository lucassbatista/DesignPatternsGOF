using ChainOfResponsability.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Middlewares
{
    internal class CheckUserMiddleware : Middleware
    {
        private Server server;

        public CheckUserMiddleware(Server server)
        {
            this.server = server;
        }

        public override bool Check(string email, string password)
        {
            if (!server.HasEmail(email)) 
            {
                Console.WriteLine("email inválido!");
                return false;
            }

            if (!server.IsValidPassword(email, password))
            {
                Console.WriteLine("E-mail ou/e senha inválidos!");
                return false;
            }

            return CheckNext(email, password);
        }
    }
}
