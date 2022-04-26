using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;
using System;

namespace ChainOfResponsability
{
    internal class Program
    {
        private static Server server;

        static void Main(string[] args)
        {
            Init();

            bool done = server.LogIn("lucasq04@gmail.com", "12345");

            if (done)
                Console.WriteLine("Sucesso!");
        }

        static void Init()
        {
            server = new Server();

            server.RegisterUser("lucasq04@gmail.com", "12345", true);
            server.RegisterUser("lucasq042@gmail.com", "12345", false);

            Middleware middleware = new CheckUserMiddleware(server);
            middleware.LinkWith(new CheckPermissionMiddleware(server))
                      .LinkWith(new CheckPasswordStrength());

            server.SetMiddleware(middleware);
        }
    }
}
