using System.Globalization;
namespace Vetores {

    class Program {
        static void Main(string[] args) { 
           /*int n = int.Parse(Console.ReadLine());

            double[] vec = new double[n];
            double media = 0;

            for (int i = 0; i < n; i++) {
                Console.Write("Digite o número {0}: ", (i+1));
                vec[i] = double.Parse(Console.ReadLine());
                media += vec[i];
            }

            Console.WriteLine("Média: " + (media / n).ToString("F2")); */

            int m = int.Parse(Console.ReadLine());
            double soma = 0;
            Produto[] vect = new Produto[m];
            for (int i = 0; i < vect.Length; i++) {
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                vect[i] = new Produto { Name = name};
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
                vect[i]= new Produto { Price = price};
                soma += vect[i].Price;

            }
            double media = soma / m;

            Console.WriteLine("Preço médio: " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}