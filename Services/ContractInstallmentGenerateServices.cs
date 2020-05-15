using Section14_exercicioFixacao.Entities;
using System;

namespace Section14_exercicioFixacao.Services
{
    class ContractInstallmentGenerateServices
    {        
        private IPaymentOperator _PaymentOperator;


        public ContractInstallmentGenerateServices(IPaymentOperator paymentOperator)
        {            
            _PaymentOperator = paymentOperator;
        }

        public void InstallmentGenerate(CustContract        contract)
        {                        
            for (int idx = 1; idx <= contract.Installments; idx++)
            {                
                DateTime dueDate = contract.Date.AddMonths(idx);
                double installmentAmount = contract.Installments > 0 ? contract.Amount / contract.Installments : 0;
                
                installmentAmount += (_PaymentOperator.InterestAmount(installmentAmount) * idx);
                installmentAmount += _PaymentOperator.FeeAmount(installmentAmount);

                contract.AddInstallment(new ContractInstallments(dueDate, idx, installmentAmount));                
            }
        }
    }
}
