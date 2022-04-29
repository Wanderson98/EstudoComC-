namespace FileStreamTest
{
    class Program
    {

        static void Main(string[] args)
        {

            string path = @"c:\temp\File1.txt";

            FileStream fs = null;

            StreamReader sr = null;
            StreamReader srr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);

                //srr = File.OpenText(path);


                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();


                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }

        }

    }


}