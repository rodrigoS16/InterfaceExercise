
namespace Section14_exercicioFixacao.Services
{
    class PayPalPaymentOperator : IPaymentOperator
    {
        private double _MonthInterest;
        private double _OperatorFee;

        public PayPalPaymentOperator(double monthInterest, double operatorFee)
        {
            _MonthInterest = monthInterest;
            _OperatorFee = operatorFee;
        }

        public double InterestAmount(double amount)
        {
            return (amount * _MonthInterest) / 100;
        }
        public double FeeAmount(double amount)
        {
            return (amount * _OperatorFee) / 100;
        }
    }
}
