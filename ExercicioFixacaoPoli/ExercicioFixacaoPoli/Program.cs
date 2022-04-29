using ExercicioFixacaoPoli.Entities;
using System.Globalization;

namespace ExercicioFixacaoPoli
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} Data");
                Console.Write("Common, used or Imported (c/u/i) ? ");
                char statusTest = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price : ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (statusTest == 'c' || statusTest == 'C')
                {
                    products.Add(new Product(name, price));
                }
                else if (statusTest == 'i' || statusTest == 'I')
                {
                    Console.Write("Custom Fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customFee));
                }
                else
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
            }

            Console.WriteLine();

            Console.WriteLine("PRICE TAGS: ");
            foreach (Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
