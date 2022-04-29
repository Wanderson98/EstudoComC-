namespace RefOut {

    class Program {

        static void Main(string[] args) {

            int a = 10;
            Console.WriteLine(a);
            Calculadora.Triple(ref a);
            Console.WriteLine(a);

            int b = 10;
            int triple;
            Calculadora.Triple( b, out triple);
            Console.WriteLine(triple);

        }
    }
}