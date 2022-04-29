using System;

namespace Aula34
{
    internal class Program
    {  //array - vetor - matriz
        static void Main(string[] args)
        {
            //string[] alunos = { "Juan", "Marcia", "Israel", "Pedro" };
            //int[] idade = { 46, 40, 20, 17 };

            //for (int i = 0; i < alunos.Length; i++)
            //{
            //    Console.WriteLine(alunos[i]);
            //    Console.WriteLine(idade[i]);
            //}
            //Array.Sort(alunos);
            //foreach (String item in alunos)
            //{
            //    Console.WriteLine(item);
            //}
            //Array.Reverse(idade);
            //foreach (int ida in idade)
            //{
            //    Console.WriteLine(ida);
            //}

            int x = 1, j = 3;
            while(x <= 5)
            {
                Console.WriteLine("repetiçao "+ x + " - "+ j);
                j = j * 2 - 1;
                x++;
            }
        }
    }
}
