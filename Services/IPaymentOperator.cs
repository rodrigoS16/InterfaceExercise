
namespace Section14_exercicioFixacao.Services
{
    interface IPaymentOperator
    {
        double InterestAmount(double amount);
        double FeeAmount(double amount);
    }
}
