using System;

namespace StatePattern
{
    public class ClosedBookingState : BookingState
    {
        public override void Book(BookingContext context, string name)
        {
            throw new InvalidOperationException("Invalid action for state: Closed");
        }

        public override void Cancel(BookingContext context)
        {
            throw new InvalidOperationException("Invalid action for state: Closed");
        }

        public override void EnterState(BookingContext context)
        {
            Console.WriteLine($"Booking ID: {context.BookingId} cancelled for {context.Name}");
        }
    }
}
