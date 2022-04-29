using System;

namespace Aula33
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Estaçao do ano: " + Estacao.Outono);
            Console.WriteLine("O nivel da turma DotNet é : " + (Nivel.medio + 1));
        }
    }

    //enum é uma classe que representa um grupo de constantes com valor de retorn Int 
    enum Nivel
    {
        baixo,
        medio,
        alto
    }

    enum Estacao
    {
        Primavera,
        Verão,
        Outono,
        Inverno
    }
}
