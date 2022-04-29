using System.Globalization;
namespace ExercicioFixacaoOO {

    class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do Dolar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar ? ");
            double qtdMoeda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);   

            double valorTotal = ConversorDeMoeda.ConversosDeMoeda(cotacao, qtdMoeda);

            Console.WriteLine("Valor a ser pago em reais: " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}