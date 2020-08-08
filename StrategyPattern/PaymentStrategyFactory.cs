using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern
{
    public class PaymentStrategyFactory
    {
        private readonly IEnumerable<IPaymentStrategy> _paymentStrategies;

        public PaymentStrategyFactory(IEnumerable<IPaymentStrategy> paymentStrategies)
        {
            _paymentStrategies = paymentStrategies;
        }

        public IPaymentStrategy GetStrategy(PaymentType paymentType)
        {
            var strategy = _paymentStrategies.FirstOrDefault(s => s.PaymentType == paymentType);

            return strategy;
        }
    }
}
