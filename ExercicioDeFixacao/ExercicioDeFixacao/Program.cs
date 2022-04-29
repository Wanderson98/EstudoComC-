using System.Globalization;

namespace ExercicioDeFixacao {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem em sua casa ? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite seu ultimo nome, idade e altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Você Digitou: ");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}