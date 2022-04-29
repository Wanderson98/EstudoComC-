namespace ManipularArquivos
{
    class Program
    {
        public static void Main(string[] args)
        {

            string sourcePath = @"c:\temp\File1.txt";
            string targetPath = @"c:\temp\File2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);

                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);

                    foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An Error Ocurred ");
                Console.WriteLine(ex.Message);
            }
        }

    }
}