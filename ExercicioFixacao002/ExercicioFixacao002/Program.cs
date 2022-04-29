using System.Globalization;
namespace ExercicioFixacao002 {
    class Program {
        static void Main(string[] args) {
            ContaBancaria conta;
            Console.Write("Digite o número da conta: ");
            int numConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o Titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S') {
                Console.Write("Entre com o valor do deposito inicial: ");
                double saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(nome, numConta, saldoInicial);
            } else {
                conta = new ContaBancaria(nome, numConta);
            }

            Console.WriteLine("Dados da Conta: " + conta);

            Console.Write("Entre com o valor do Deposito: $ ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.DepositoConta(quantia);

            Console.WriteLine("Dados de Conta Atualizado: " + conta);
            Console.Write("Entre com o valor do Saque: $ ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.SaqueConta(quantia);
            Console.WriteLine("Dados de Conta Atualizado: " + conta);

          

        }
    }
}