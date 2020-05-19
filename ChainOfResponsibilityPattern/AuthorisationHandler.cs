using System;

namespace ChainOfResponsibilityPattern
{
    public class AuthorisationHandler : RequestHandler
    {
        public override void Handle(Request request)
        {
            if (request.Role == "Admin")
            {
                this.nextHandler.Handle(request);
            }
            else
            {
                Console.WriteLine("Could not authorise: User has incorrect role.");
            }
        }
    }
}
