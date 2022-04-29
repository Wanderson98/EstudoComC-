namespace TryCatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int resul = n1 / n2;

                Console.WriteLine(resul);
            } 
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }
    }
}