using System;
using System.Collections.Generic;
using System.Text;

namespace Section14_exercicioFixacao.Entities
{
    class CustContract
    {
        public int Number { get; private set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public int Installments { get; set; }
        public List<ContractInstallments> InstallmentsList { get; set; }

        public CustContract(int number, DateTime date, double amount, int installments)
        {
            Number = number;
            Date = date;
            Amount = amount;
            Installments = installments;
            InstallmentsList = new List<ContractInstallments>();
        }

        public void AddInstallment(ContractInstallments installment)
        {
            InstallmentsList.Add(installment);
        }
    }
}
