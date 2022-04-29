using System.Globalization;
namespace Nome {
    class Program {
        static void Main(string[] args) {
            /*
            Pessoa primeiraPessoa = new Pessoa();
            Pessoa segundaPessoa = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            primeiraPessoa.Nome = Console.ReadLine();
            primeiraPessoa.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa: ");
            segundaPessoa.Nome = Console.ReadLine();
            segundaPessoa.Idade = int.Parse(Console.ReadLine());    

            if(primeiraPessoa.Idade > segundaPessoa.Idade) {
                Console.WriteLine("Pessoa mais velha: " + primeiraPessoa.Nome);
            } else {
                Console.WriteLine("Pessoa mais velha: " + segundaPessoa.Nome);
            }
            */
            Funcionario primeiro = new Funcionario();
            Funcionario segundo = new Funcionario();

            Console.WriteLine("Digite os dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            primeiro.Nome = Console.ReadLine();
            Console.Write("Salario: R$ ");
            primeiro.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os dados do segundo funcionário: ");
            Console.Write("Nome: ");
            segundo.Nome = Console.ReadLine();
            Console.Write("Salario : R$ ");
            segundo.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario  = (primeiro.Salario + segundo.Salario) / 2.0;

            Console.WriteLine("Média Salarial: R$ " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}