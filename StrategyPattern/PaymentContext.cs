namespace StrategyPattern
{
    public class PaymentContext
    {
        private readonly PaymentStrategyFactory _paymentStrategyFactory;

        public PaymentContext(PaymentStrategyFactory paymentStrategyFactory)
        {
            _paymentStrategyFactory = paymentStrategyFactory;
        }

        public void MakePayment(PaymentType paymentType, float amount)
        {
            var strategy = _paymentStrategyFactory.GetStrategy(paymentType);

            strategy.MakePayment(amount);
        }
    }
}
