using System;

namespace ChainOfResponsibilityPattern
{
    public class RouteHandler : RequestHandler
    {
        public override void Handle(Request request)
        {
            Console.WriteLine($"Handled request for route: {request.Route}");
        }
    }
}
