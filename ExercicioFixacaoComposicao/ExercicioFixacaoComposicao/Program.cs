using System.Globalization;
using ExercicioFixacaoComposicao.Entities;
using ExercicioFixacaoComposicao.Entities.Enums;

namespace ExercicioFixacaoComposicao;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter client data: ");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Birth Date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Enter order data: ");
        Console.Write("Status: ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

        Client client = new Client(name, email, date);
        Order order = new Order(DateTime.Now, status, client);

        Console.Write("How many items to this order? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Enter #{i} item data");
            Console.Write("Product Name: ");
            string nameProduct = Console.ReadLine();
            Console.Write("Product Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product product = new Product(nameProduct, price);

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            
            OrderItem item = new OrderItem(quantity, price, product);

            order.AddItem(item);
           
        }
        Console.WriteLine(order);
    }
}
