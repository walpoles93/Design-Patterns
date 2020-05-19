using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main()
        {
            // initialise chain of responsibility
            var authentication = new AuthenticationHandler();
            var authorisation = new AuthorisationHandler();
            var route = new RouteHandler();
            authentication.SetNext(authorisation);
            authorisation.SetNext(route);

            Console.WriteLine("Request 1");
            var request1 = new Request
            {
                Username = "NotAdmin",
                Password = "Password",
                Role = "Admin",
                Route = "/my/route/",
            };
            authentication.Handle(request1);

            Console.WriteLine("Request 2");
            var request2 = new Request
            {
                Username = "Admin",
                Password = "Password",
                Role = "NotAdmin",
                Route = "/my/route/",
            };
            authentication.Handle(request2);

            Console.WriteLine("Request 3");
            var request3 = new Request
            {
                Username = "Admin",
                Password = "Password",
                Role = "Admin",
                Route = "/my/route",
            };
            authentication.Handle(request3);
        }
    }
}
