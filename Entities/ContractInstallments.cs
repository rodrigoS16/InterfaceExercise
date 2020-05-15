using System;
using System.Globalization;

namespace Section14_exercicioFixacao.Entities
{
    class ContractInstallments
    {
        public DateTime DueDate { get; private set; }
        public int Installment { get; private set; }
        public double InstallmentAmount { get; private set; }

        public ContractInstallments(DateTime dueDate, int installment, double installmentAmount)
        {
            DueDate = dueDate;
            Installment = installment;
            InstallmentAmount = installmentAmount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy") + " - " + InstallmentAmount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
