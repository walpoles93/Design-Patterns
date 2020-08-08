using Microsoft.Extensions.DependencyInjection;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // set up DI
            var serviceProvider = new ServiceCollection()
                .AddTransient<IPaymentStrategy, CashPaymentStrategy>()
                .AddTransient<IPaymentStrategy, CardPaymentStrategy>()
                .AddTransient<PaymentStrategyFactory>()
                .AddTransient<PaymentContext>()
                .BuildServiceProvider();

            // get user input
            Console.WriteLine("Enter a payment method");
            Console.WriteLine("Cash [1]");
            Console.WriteLine("Card [2]");
            var typeId = int.Parse(Console.ReadLine());
            var paymentType = (PaymentType)typeId;

            Console.WriteLine("Enter payment amount");
            var amount = float.Parse(Console.ReadLine());

            // pick strategy at runtime
            var context = serviceProvider.GetService<PaymentContext>();
            context.MakePayment(paymentType, amount);
        }
    }
}
