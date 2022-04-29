namespace Matrizes {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite o valor de n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] a = new int[n, n];
            int neg = 0;
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite o valor: ");
                string[] vec = Console.ReadLine().Split(' ');
                for (int y = 0; y < n; y++) {
                    a[i, y] = int.Parse(vec[y]);
                    if (a[i,y] < 0) {
                        neg++;
                    }
                }
                  
            }
            Console.WriteLine("Diagonal Princial");

            for (int i = 0; i < n; i++) {
                Console.Write(a[i,i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Números negativos: " + neg);

        }
    }
}