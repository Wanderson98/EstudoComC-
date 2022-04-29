using System.Globalization;

namespace EstrutraRepticao {
    class Program {
        static void Main(string[] args) {

            /*
            Console.Write("Digite um numero: ");
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (num >= 0.0) {
                double raiz = Math.Sqrt(num);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
               Console.Write("Digite outro numero: ");
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número Negativo");
            */

            Console.Write("Quantos número vc vai digitar? ");
            int x = int.Parse(Console.ReadLine());
            int y = 0, valor = 0;
            for (int i = 0; i < x; i++) {
                Console.Write("Digite o Número: ");
                y = int.Parse(Console.ReadLine());
                valor += y;
            }
            Console.WriteLine("Soma: " + valor);

        }

    }
}