namespace StatePattern
{
    public abstract class BookingState
    {
        public abstract void EnterState(BookingContext context);

        public abstract void Book(BookingContext context, string name);

        public abstract void Cancel(BookingContext context);
    }
}
