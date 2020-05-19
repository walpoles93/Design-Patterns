namespace ChainOfResponsibilityPattern
{
    public abstract class RequestHandler : IRequestHandler
    {
        protected IRequestHandler nextHandler;

        public RequestHandler()
        {
            nextHandler = null;
        }

        public abstract void Handle(Request request);

        public void SetNext(IRequestHandler handler)
        {
            this.nextHandler = handler;
        }
    }
}





