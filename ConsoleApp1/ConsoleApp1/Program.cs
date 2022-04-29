using System.Globalization;
namespace Zueira {
    class program {

        const double pi = 3.14159;

        static void Main(String[] args) {

            //exercicio1
            Console.WriteLine("Digite o número");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            double num2 = double.Parse(Console.ReadLine());

            double resul = num1 + num2; 
            
            Console.WriteLine("Soma: " + resul.ToString("F2", CultureInfo.InvariantCulture));

            //exercicio2
            Console.WriteLine("Digite o raio do circulo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * (Math.Pow(raio, 2.0));
            Console.WriteLine("A: " + area.ToString("F4", CultureInfo.InvariantCulture));

            //exercicio3
            int A = 0,B = 0, C = 0, D = 0, resul1;
            Console.WriteLine("Digite os números: ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            resul1 = ((A * B) - (C * D));

            Console.WriteLine("Diferença: " + resul1);
          
            //exercicio4
            int numFuncionario, horastrabalhadas;
            double valorHora, salario;
            Console.WriteLine("Digite os dados: ");
            numFuncionario = int.Parse(Console.ReadLine());
            horastrabalhadas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horastrabalhadas * valorHora;

            Console.WriteLine("Number: " + numFuncionario);
            Console.WriteLine("Salary: U$" + salario.ToString("F2", CultureInfo.InvariantCulture));


            //exercicio5 com for
            int[] codPeca = new int[2]; 
            int[] numPeca = new int[2];
            double[] valorPeca = new double[2];
            double valorTotal = 0;

            for (int i = 0; i < 2; i++) {
                Console.WriteLine("Digite os dados");
                codPeca[i] = int.Parse(Console.ReadLine());
                numPeca[i] = int.Parse(Console.ReadLine());
                valorPeca[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                valorTotal += (numPeca[i] * valorPeca[i]);
            }

            Console.WriteLine("Valor total a pagar: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            //exercicio5
            double valorTotal1 = 0;
            Console.WriteLine("Digite dados produto 1: ");
            string[] vet = Console.ReadLine().Split(' ');
            int codPro1 = int.Parse(vet[0]);
            int numPro1 = int.Parse(vet[1]);
            double valorPeca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine("Digite dados produto 2: ");
            string[] vet1 = Console.ReadLine().Split(' ');
            int codPro2 = int.Parse(vet1[0]);
            int numPro2 = int.Parse(vet1[1]);
            double valorPeca2 = double.Parse(vet1[2], CultureInfo.InvariantCulture);
            
            valorTotal1 = (valorPeca1 * numPro1) + (valorPeca2 * numPro2);

            Console.WriteLine("Valor total a pagar: R$ " + valorTotal1.ToString("F2", CultureInfo.InvariantCulture));

            //exercicio6
            Console.WriteLine("Digite os dados A, B e C: ");
            string[] vet2 = Console.ReadLine().Split(' ');
            double a = double.Parse(vet2[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet2[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double areaTriangulo = (a * c) / 2;
            double areaCirculo = pi * (Math.Pow(c, 2.0));
            double areaTrapezio = ((a + b) * c) / 2;
            double areaQuadrado = b * b;
            double areaRetangulo = a * b;

            Console.WriteLine("Triangulo: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retangulo: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}