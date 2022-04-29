using System;
using System.IO;

namespace Aula11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"D:\teste\arquivo.txt");
            sw.Write("Primeira linha");
            sw.WriteLine("Segunda linha");
        }
    }
}
