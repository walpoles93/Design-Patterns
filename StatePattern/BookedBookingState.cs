using System;

namespace StatePattern
{
    public class BookedBookingState : BookingState
    {
        public override void Book(BookingContext context, string name)
        {
            throw new InvalidOperationException("Invalid action for state: Booked");
        }

        public override void Cancel(BookingContext context)
        {
            context.TransitionToState(new ClosedBookingState());
        }

        public override void EnterState(BookingContext context)
        {
            Console.WriteLine($"Booking ID: {context.BookingId} created for {context.Name}");
        }
    }
}
