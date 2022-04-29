using ExerciseTryCatchFix.Entities;
using System.Globalization;

namespace ExerciseTryCatchFix
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, name, initialBalance, withdrawLimit);

                Console.Write("\nEnter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.Withdraw(withdraw);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}