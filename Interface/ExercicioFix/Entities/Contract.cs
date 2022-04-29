using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFix.Entities
{
    internal class Contract
    {
        public int Number { get; }
        public DateTime Date { get; }
        public double TotalValue { get; private set; }
        public List<Installments> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installments>();
        }
        public void AddInstallment(Installments installment)
        {
            Installments.Add(installment);
        }
    }
}
