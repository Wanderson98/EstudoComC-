using System.Globalization;
namespace ExercicioProposto {

    class Program {
        static void Main(string[] args) {

            //Exercicio1
            Console.WriteLine("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0) {
                Console.WriteLine("Número Não Negativo !!");
            } else {
                Console.WriteLine("Número Negativo !!");
            }

            //Exercicio2
            Console.WriteLine("Digite um número inteiro: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0) {
                Console.WriteLine("PAR !");
            } else {
                Console.WriteLine("IMPAR");
            }

            //Exercicio3
            Console.WriteLine("Digite dois números inteiros: ");
            string[] vet = Console.ReadLine().Split(' ');
            int num2 = int.Parse(vet[0]);
            int num3 = int.Parse(vet[1]);

            if (num2 % num3 == 0 || num3 % num2 == 0) {
                Console.WriteLine("São Multiplos");

            } else {
                Console.WriteLine("Não São Multiplos");
            }

            //Exercicio4
            Console.WriteLine("Digite a hora inicial e a hora final: ");
            string[] vet1 = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(vet1[0]);
            int horaFinal = int.Parse(vet1[1]);

            int duracao;
            if (horaInicial < horaFinal) {
                duracao = horaFinal - horaInicial;

            } else {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O jogo durou: {0} Horas !", duracao);

            //Exercicio5
            Console.WriteLine("Digite o código e a quantidade: ");
            string[] vet4 = Console.ReadLine().Split(' ');
            int cod = int.Parse(vet4[0]);
            int qtd = int.Parse(vet4[1]);
            double conta = 0.0;

            if (cod == 1) {
                conta = qtd * 4.00;
            } else if (cod == 2) {
                conta = qtd * 4.50;
            } else if (cod == 3) {
                conta = qtd * 5.00;
            } else if (cod == 4) {
                conta = qtd * 2.00;
            } else if (cod == 5) {
                conta = qtd * 1.50;
            } else {
                Console.WriteLine("Codifo invalido");
            }

            Console.WriteLine("Total: R$ {0}", conta.ToString("F2", CultureInfo.InvariantCulture));

            //Exercicio6
            Console.WriteLine("Digite o número");
            double nume = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (nume < 0 || nume > 100) {
                Console.WriteLine("Fora do Intervalo");
            } else if (nume <= 25) {
                Console.WriteLine("Intervalo [0 - 25]");
            } else if (nume <= 50) {
                Console.WriteLine("Intervalo [25 - 50]");
            } else if (nume <= 75) {
                Console.WriteLine("Intervalo [50 - 75]");
            } else {
                Console.WriteLine("Intervalo [75 - 100]");

            }

            //Exercicio7
            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0) {
                Console.WriteLine("Origem");
            } else if (x == 0.0) {
                Console.WriteLine("Eixo Y");
            } else if (y == 0.0) {
                Console.WriteLine("Eixo X");
            } else if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Q1");
            } else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("Q2");
            } else if (x < 0.0 && y < 0.0) {
                Console.WriteLine("Q3");
            } else {
                Console.WriteLine("Q4");
            }


            //Exercicio8
            Console.WriteLine("Digite seu salario: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0;

            if (salario < 0) {
                Console.WriteLine("Valor Invalido");
            } else if (salario <= 2000.00) {
                Console.WriteLine("Isento");
            } else if (salario <= 3000.00) {
                imposto = ((salario - 2000.00) * 0.08);
                Console.WriteLine("R$ {0}", imposto.ToString("F2", CultureInfo.InvariantCulture));
            } else if (salario <= 4500.00) {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
                Console.WriteLine("R$ {0}", imposto.ToString("F2", CultureInfo.InvariantCulture));
            } else {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
                Console.WriteLine("R$ {0}", imposto.ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}