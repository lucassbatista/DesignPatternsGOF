using ChainOfResponsability.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Servers
{
    internal class Server
    {
        private Dictionary<string, string> _users = new Dictionary<string, string>();
        private Dictionary<string, string> _adminUsers = new Dictionary<string, string>();

        private Middleware middleware;

        public void SetMiddleware(Middleware middleware)
        {
            this.middleware = middleware;
        }

        public bool LogIn(string email, string password)
        {
            if (!middleware.Check(email, password))
                return false;

            Console.WriteLine("Usuário Autorizado");
            return true;
        }

        public void RegisterUser(string email, string password, bool isAdmin)
        {
            _users.Add(email, password);

            if (isAdmin)
                _adminUsers.Add(email, password);
        }

        public bool HasEmail(string email)
        {
            return _users.ContainsKey(email);
        }

        public bool IsValidPassword(string email, string password)
        {
            string value = string.Empty;
            _users.TryGetValue(email, out value);

            return value == password;
        }

        public bool IsAdmin(string email)
        {
            return _adminUsers.ContainsKey(email);
        }
    }
}
