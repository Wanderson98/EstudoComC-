using System;
using System.Collections.Generic;

namespace ExerciciosFeriados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> pessoas = new List<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Digite o nome da pessoa #{i +1}: ");
                pessoas.Add(Console.ReadLine().ToLower());
            }
            pessoas.Sort();
            foreach (var item in pessoas)
            {
               Console.WriteLine(item);
            }

            //Console.Write("\nDigite o nome de uma pessoa: ");
            //string busca = Console.ReadLine().ToLower();

            //if (pessoas.Contains(busca))
            //{
            //    Console.WriteLine("ACHEI");
            //}
            //else
            //{
            //    Console.WriteLine("NÃO ACHEI");
            //}
        }
    }
}
