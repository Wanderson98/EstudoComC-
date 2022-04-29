using System.Globalization;
namespace ExercicioListas {

    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Funcionário #{0}: ", i);
                Console.Write("ID: ");
                int idd = int.Parse(Console.ReadLine());
                Console.Write("Nome : ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Add(new Funcionario(idd, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Digite o id do funcionario que vai receber o aumento: ");
            int id = int.Parse(Console.ReadLine());

            Funcionario func = lista.Find(x => x.IdFuncionario == id);
            if (func != null) {
                Console.Write("\nDados do funcionário selecionado: ");
                Console.WriteLine("\nId: " + func.IdFuncionario + "\nNome: "
                    + func.NomeFuncionario + "\nSalário: " + func.SalarioFuncionario);
                Console.Write("Digite a porcentangem do aumento: ");
                double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentoSalario(taxa);
            } else {
                Console.WriteLine("Esse funcionário não existe");
            }

            Console.WriteLine("\nLista de Funcionarios Atualizada: ");
            foreach (Funcionario obj in lista) {
                Console.WriteLine(obj);
            }
        }
    }
}