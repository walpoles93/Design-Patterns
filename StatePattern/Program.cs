using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new BookingContext();

            while (true)
            {
                Console.WriteLine("[N] New Booking\t[B] Book (enter name)\t[C] Cancel booking");
                var command = Console.ReadLine();

                try
                {
                    if (command == "N")
                    {
                        context = new BookingContext();
                    }

                    if (command == "B")
                    {
                        Console.WriteLine("Enter name:");
                        var name = Console.ReadLine();

                        context.Book(name);
                    }

                    if (command == "C")
                    {
                        context.Cancel();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
