using System.Globalization;
using ExerciseClassAbstract.Entities;
using ExerciseClassAbstract.Entities.Enums;
namespace ExerciseClassAbstract
{
    class Program
    {
        public static void Main(string[] args)
        {   
            List<Shape> shape = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data");
                Console.Write("Rectangle or Circle (c/r) ? ");
                char test = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (test == 'r' || test == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Heigth: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shape.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shape.Add(new Circle(radius, color));
                }

            }

            Console.WriteLine();

            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape item in shape)
            {
                Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}