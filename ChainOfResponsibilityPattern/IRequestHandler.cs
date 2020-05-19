namespace ChainOfResponsibilityPattern
{
    public interface IRequestHandler
    {
        void Handle(Request request);

        void SetNext(IRequestHandler handler);
    }
}
