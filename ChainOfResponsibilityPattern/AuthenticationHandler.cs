using System;

namespace ChainOfResponsibilityPattern
{
    public class AuthenticationHandler : RequestHandler
    {
        public override void Handle(Request request)
        {
            if (request.Username == "Admin" && request.Password == "Password")
            {
                this.nextHandler.Handle(request);
            }
            else
            {
                Console.WriteLine("Could not authenticate: Incorrect username or password.");
            }
        }
    }
}
