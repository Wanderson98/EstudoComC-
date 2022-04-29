﻿using System.Globalization;
using ExercicioPoli1.Entities;


namespace ExercicioPoli1
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} Data");
                Console.Write("Outsourced (y/n)? ");
                char outTest = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outTest == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourceEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }

            }

            Console.WriteLine();
            Console.WriteLine("Payments: ");

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}