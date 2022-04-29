using System;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\File1.txt";
            string targetPath = @"c:\temp\File2.txt";

            try
            {

                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToLower());
                    }
                }

            }
            catch (IOException e )
            {

                throw;
            }
        }
    }
}
