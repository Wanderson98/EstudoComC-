using System.Globalization;
namespace ExercicioProposto {
    class Program {
        static void Main(string[] args) {
            //exercicio1
            Console.Write("Digite um valor inteiro entre 1 e 1000: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            } 
            //exercicio2
            Console.Write("Digite a quantidade de números a digitar: ");
            int xx = int.Parse(Console.ReadLine());
            int inside = 0, outside = 0;
            for (int i = 0; i < xx; i++) {
                Console.Write("Digite o número inteiro: ");
                int num = int.Parse(Console.ReadLine());
                if (num >= 10 && num <= 20) {
                    inside++;
                } else { 
                    outside++;
                }
            }

            Console.WriteLine("IN: " + inside);
            Console.WriteLine("OUT: " + outside);

            //exercicio3
            Console.Write("Digite a quantidade de números a digitar: ");
            int xxx = int.Parse(Console.ReadLine());
            double[] media = new double[xxx];
            for (int i = 0; i < xxx; i++) {
                Console.Write("Digite os números: ");
                string[] vet = Console.ReadLine().Split(' ');
                double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

                media[i] = (a * 2.0 + b * 3.0 + c * 5.0) / 10;
           }
            for (int i = 0; i < xxx; i++) {
                Console.WriteLine("Média: " + media[i].ToString("F1", CultureInfo.InvariantCulture));
            }


            //exercicio4
            Console.Write("Digite a quantidade de números a digitar: ");
            int xxxx = int.Parse(Console.ReadLine());

            for (int i = 0; i < xxxx; i++) {

                Console.Write("Digite os pares de número: ");
                string[] vet1 = Console.ReadLine().Split(' ');
                double a = double.Parse(vet1[0]);
                double b = double.Parse(vet1[1]);

                if (b == 0) {
                    Console.WriteLine("Divisão Inválida !");
                }

                double divisao = a / b;
                Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));

            }

            //exercicio5
            Console.Write("Digite um número: ");
            int xy = int.Parse(Console.ReadLine());
            int fatorial = xy;
            for (int i = xy - 1;i >= 1; i--) {
       
                fatorial = fatorial * i;
            }
            Console.WriteLine(fatorial);

            //exercicio6
            Console.Write("Digite um número: ");
            int xxy = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= xxy; i++) {
                if(xxy % i == 0) {
                    Console.WriteLine(i);
                }
                
            }
            //exercicio7
            Console.Write("Digite um número: ");
            int xxyy = int.Parse(Console.ReadLine());
            for (int i = 1; i <= xxyy; i++) {
                double[] qua =  new double[xxyy+1];
                double[] cubo = new double[xxyy+1];

                qua[i] = Math.Pow(i, 2.0);
                cubo[i] = Math.Pow(i, 3.0);
                
                Console.WriteLine("{0} {1} {2}", i, qua[i], cubo[i]);
            }



        }
    }
}