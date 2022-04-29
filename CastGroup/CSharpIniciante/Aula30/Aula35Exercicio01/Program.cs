using System;
using System.Collections.Generic;

namespace Aula35Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Digite a quantidade de alunos para efetuar o calculo da média: ");
            //int numAlunos = int.Parse(Console.ReadLine());
            //double[] media = new double[numAlunos];
            //string[] alunos = new string[numAlunos];

            //for (int i = 0; i < numAlunos; i++)
            //{
            //    double[] notas = new double[4];
            //    Console.WriteLine($"Dados do Aluno #{i+1}");
            //    Console.Write("Digite o nome do aluno: ");
            //    alunos[i] = Console.ReadLine();
            //    for (int j = 0; j < notas.Length; j++)
            //    {
            //        Console.Write($"Digite o a nota do {j + 1} bimestre: ");
            //        notas[j] = double.Parse(Console.ReadLine());

            //    }
            //    media[i] = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;


            //}
            //Console.WriteLine();

            //for (int i = 0; i < numAlunos; i++)
            //{
            //    if(media[i] < 5)
            //    {
            //        Console.WriteLine($"O Aluno {alunos[i]} ficou com média {media[i]:F2} e está REPROVADO !");
            //    } else if(media[i] < 7)
            //    {
            //        Console.WriteLine($"O Aluno {alunos[i]} ficou com média {media[i]:F2} e está em RECUPERAÇÃO !");
            //    } else
            //    {
            //        Console.WriteLine($"O Aluno {alunos[i]} ficou com média {media[i]:F2} e está APROVADO !");
            //    }
            //}

            string frase = "Estamos estudando C# na Cast, estudando muito ";
            string[] palavras = frase.Split(' ');

            foreach (string item in palavras)
            {
                Console.WriteLine("{0}", item);
            }
            bool buscaBalavra = frase.Contains("agora");
            if (buscaBalavra)
            {
                Console.WriteLine("Contem a palavra estudando!");
            }
            else
            {
                Console.WriteLine("Não tem !");
            }
        }
    }
}
