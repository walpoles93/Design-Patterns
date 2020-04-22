using System;

namespace StatePattern
{
    public class BookingContext
    {
        public Guid BookingId { get; set; }

        public string Name { get; set; }

        public BookingState State { get; set; }

        public BookingContext()
        {
            this.TransitionToState(new NewBookingState());
        }

        public void TransitionToState(BookingState state)
        {
            this.State = state;

            this.State.EnterState(this);
        }

        public void Book(string name)
        {
            this.State.Book(this, name);
        }

        public void Cancel()
        {
            this.State.Cancel(this);
        }
    }
}
