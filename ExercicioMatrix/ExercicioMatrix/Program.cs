namespace ExercicioMatrix
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Digite o valor de M: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Digite os números: ");
                string[] vec = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {

                    matriz[i, j] = int.Parse(vec[j]);

                }
            }

            Console.WriteLine("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == num)
                    {
                        Console.Write("\nPosição: " + i + ", " + j);
                        if (j > 0)
                        {
                            Console.Write("\nEsquerda: {0}", matriz[i, (j - 1)]);
                        }
                        if (i > 0)
                        {
                            Console.Write("\nEm Cima: {0}", matriz[(i - 1), j]);
                        }
                        if (j < n - 1)
                        {
                            Console.Write("\nDireita: {0}", matriz[i, (j + 1)]);
                        }
                        if (i < m - 1)
                        {
                            Console.Write("\nEmbaixo: {0}", matriz[(i + 1), j]);
                        }
                    }
                }
            }


        }
    }

}