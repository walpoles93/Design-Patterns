using System;

namespace StrategyPattern
{
    public class CashPaymentStrategy : IPaymentStrategy
    {
        public PaymentType PaymentType => PaymentType.Cash;

        public void MakePayment(float amount)
        {
            Console.WriteLine($"You made a cash payment of {amount}");
        }
    }
}
