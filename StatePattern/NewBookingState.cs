using System;

namespace StatePattern
{
    public class NewBookingState : BookingState
    {
        public override void Book(BookingContext context, string name)
        {
            context.Name = name;

            context.TransitionToState(new BookedBookingState());
        }

        public override void Cancel(BookingContext context)
        {
            context.TransitionToState(new ClosedBookingState());
        }

        public override void EnterState(BookingContext context)
        {
            context.BookingId = Guid.NewGuid();

            Console.WriteLine($"Created new booking ID: {context.BookingId}");
        }
    }
}
