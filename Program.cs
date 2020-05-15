using Section14_exercicioFixacao.Entities;
using Section14_exercicioFixacao.Services;
using System;
using System.Globalization;

namespace Section14_exercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract amount: ");
            double contractAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Number of installments: ");
            int contractInstallments = int.Parse(Console.ReadLine());

            CustContract contract = new CustContract(contractNumber, contractDate, contractAmount, contractInstallments);
            ContractInstallmentGenerateServices services = new ContractInstallmentGenerateServices(new PayPalPaymentOperator(1, 2));
            services.InstallmentGenerate(contract);

            foreach(ContractInstallments installment in contract.InstallmentsList)
            {
                Console.WriteLine(installment);
            }


        }
    }
}
