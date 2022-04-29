namespace Params {
    class Program {
        static void Main(string[] args) {

            int s1 = Calculadora.Sum(3, 5, 4, 56, 4, 23, 4, 5, 23, 2);
            int s2 = Calculadora.Sum(3, 5, 4);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}