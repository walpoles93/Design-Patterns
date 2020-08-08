namespace StrategyPattern
{
    public interface IPaymentStrategy
    {
        PaymentType PaymentType { get; }

        void MakePayment(float amount);
    }
}
