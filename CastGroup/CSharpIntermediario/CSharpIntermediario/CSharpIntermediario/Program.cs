using System;
using System.IO;

namespace CSharpIntermediario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Visualizar conteudo disco (drive)
            //DriveInfo di = new DriveInfo(@"D:\");
            //Console.WriteLine("Espaço livre: " + di.TotalFreeSpace);
            //Console.WriteLine("Nome Volume: " + di.VolumeLabel);

            ////Criar Pastas 
            //string pastaCriada = @"d:\Teste";


            //if (!Directory.Exists(pastaCriada))
            //{
            //    Directory.CreateDirectory(pastaCriada);
            //    Console.WriteLine("Pasta criada");
            //}
            //else
            //{
            //    Console.WriteLine("Pasta já existe");
            //}

            //Copia de arquivos, pastas

            string nomeArquivo = "texto.txt";
            string pastaOrigem = @"D:\Teste";
            string pastaDestino = @"D:\Teste\Subdir";

            string arquivoOrigem = Path.Combine(pastaOrigem, nomeArquivo);
            string arquivoDestino = Path.Combine(pastaDestino, nomeArquivo);

            File.Delete(@"D:\Teste\texto.txt");
        }
    }
}
