using System;

namespace Exe82
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vetorA = new double[];
            double[] vetorM = new double[vetorA.Length];

            for (int i = 0; i < vetorA.Length; i++)
            {
                Console.WriteLine("Digite o número # {0}", i + 1);
                vetorA[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine());

            for (int i = 0; i < vetorM.Length; i++)
            {
                vetorM[i] = vetorA[i] * num;
            }

            foreach (var item in vetorM)
            {
                Console.WriteLine(item);
            }
        }
    }
}
