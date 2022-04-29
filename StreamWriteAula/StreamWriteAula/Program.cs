namespace StreamWriteAula
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\File1.txt";
            string targetPath = @"c:\temp\File2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath) )
                {

                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }

                }




            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}