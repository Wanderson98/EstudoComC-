using System.Globalization;

namespace ExercicioFixacaoVetor {

    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos quartos serão alugados: ");
            int n = int.Parse(Console.ReadLine());
            Estudante[] aluno = new Estudante[10];

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("\nAluguel #{0}", i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                aluno[quarto] = new Estudante(nome, email);

            }

            Console.WriteLine("\nQuartos Ocupados!");
            for (int i = 0; i < 10; i++) {
                if (aluno[i] != null) {
                    Console.WriteLine(i + ": "+ aluno[i]);
                }


            }
        }
    }
}
