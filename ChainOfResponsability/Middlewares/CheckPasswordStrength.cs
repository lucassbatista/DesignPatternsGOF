using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Middlewares
{
    internal class CheckPasswordStrength : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (password.Equals("12345"))
                Console.WriteLine("Senha fraca, sujerimos que troque de senha!");

            return CheckNext(email, password);
        }
    }
}
