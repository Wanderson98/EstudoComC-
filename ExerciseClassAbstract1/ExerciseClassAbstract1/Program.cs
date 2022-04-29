using ExerciseClassAbstract1.Entities;
using System.Globalization;

namespace ExerciseClassAbstract1
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n ; i++)
            {
                Console.WriteLine($"Tax Payer #{i} data: ");
                Console.Write("Individual or Company (i/c) ");
                char test = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income : ");
                double anualIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (test == 'c' || test == 'C')
                {
                    Console.Write("Numer of Employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
                else if (test == 'i' || test == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            double totalTaxesPaid = 0;
            foreach (TaxPayer item in list)
            {
                Console.WriteLine(item.Name + ": $ " + item.Tax().ToString("F2", CultureInfo.InvariantCulture));
                totalTaxesPaid += item.Tax();
            }

            Console.WriteLine("\nTotal Taxes: $ " + totalTaxesPaid.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}