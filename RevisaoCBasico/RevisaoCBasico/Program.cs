using System;
using System.Linq;

namespace RevisaoCBasico
{
    internal class Program
    {
        static void Main(string[] ags)
        {
            //int[] numeros = { 21, 23, 43, 45, 35, 67, 37, 58,79, 140 };
            //Console.WriteLine("Maior valor do vetor: " + numeros.Max());
            //Console.WriteLine("Menor valor do vetor: " + numeros.Min());
            //Console.WriteLine("Soma valores do vetor: " + numeros.Sum());
            //Console.WriteLine("Média dos valores do vetor: " + numeros.Average());

            int[,] a = new int[2, 2];

            a[0, 0] = 1;
            a[0, 1] = 2;
            a[1, 0] = 3;
            a[1, 1] = 4;

            foreach (var item in a)
            {
                Console.WriteLine(item.ToString());
            }
    
        }
    }
}
