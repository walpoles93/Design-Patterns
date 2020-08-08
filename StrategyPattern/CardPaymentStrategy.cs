using System;

namespace StrategyPattern
{
    public class CardPaymentStrategy : IPaymentStrategy
    {
        public PaymentType PaymentType => PaymentType.Card;

        public void MakePayment(float amount)
        {
            Console.WriteLine($"You made a card payment of {amount}");
        }
    }
}
