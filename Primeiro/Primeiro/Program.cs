using System.Globalization; //chamada para biblioteca system

namespace Primeiro // namespace não é obrigatorio, mas é uma boa pratica de programação e organização
{
    class program //class padrão das linguagens Orientas a objeto
    {
        static void Main(String[] args) // entry point da aplicação, ou seja, por onde ela começa
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            double p, areax, areaY;

            Console.WriteLine("Entre com as medidas do triangulo X: "); 
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triangulo y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            areax = x.AreaTriangulo();
            areaY = y.AreaTriangulo();


            Console.WriteLine("Area de x = " + areax.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areax > areaY) {
                Console.WriteLine("Maior Area: X");
            } else {
                Console.WriteLine("Maior Area: Y");
            }
        }

    }
}
