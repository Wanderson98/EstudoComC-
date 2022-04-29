using System.Globalization;
namespace ExerciciosOO1 {
    class Program {
        static void Main(string[] args) {
            //Exercicio1
            Retangulo re = new Retangulo();
            Console.WriteLine("Entre com a largura e a altura do retangulo: ");
            Console.Write("Largura: ");
            re.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            re.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(re);
            
            Funcionario fun = new Funcionario();
            //Exercicio2
            Console.WriteLine("Digite os dados do Funcionario: ");
            Console.Write("Nome: ");
            fun.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            fun.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            fun.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + fun);

            Console.Write("\nDigite a porcentagem para aumentar o salario: ");
            double tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            fun.AumentarSalario(tax);

            Console.WriteLine("\nDados atualizados: " + fun);

            //Exercicio3
            Aluno a = new Aluno();
            Console.Write("Nome do Aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("\nDigite as três notas do aluno: ");
            Console.Write("Nota 1: ");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 2: ");
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 3: ");
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\n" + a);
        }

    }

}