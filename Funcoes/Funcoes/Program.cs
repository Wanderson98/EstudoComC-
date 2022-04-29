namespace Funcoes {

    class program {
        static void Main(string[] args) {

            Console.WriteLine("Digite três números: ");
            string[] vet = Console.ReadLine().Split(' ');
            int n1 = int.Parse(vet[0]);
            int n2 = int.Parse(vet[1]);
            int n3 = int.Parse(vet[2]);

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior é: " + resultado);
        }

        static int Maior(int n1, int n2, int n3) {
            int maior = 0;
            if (n1 > n2 && n1 > n3) {
                maior = n1;
            } else if (n2 > n3) {
                maior = n2;
            } else {
              maior =  n3;
            }
            return maior;
        }
    }
}