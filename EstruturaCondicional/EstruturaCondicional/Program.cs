namespace EstrutaCondicional {

    class Program {
        static void Main(string[] args) {

            /*
            int x = 10;

            Console.WriteLine("Bom dia !");

            if ( x > 5) {
                Console.WriteLine("Boa tarde !");
            }
            
            Console.WriteLine("Boa Noite !");
            

            Console.WriteLine("Entre com um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) {
                Console.WriteLine("Número Par");
            } else {
                Console.WriteLine("Número impar");
            }
            */

            Console.WriteLine("Qual a hora atual: ");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12) {
                Console.WriteLine("Bom dia !");
            } else if (hora >= 12 && hora < 18) {
                Console.WriteLine("Boa Tarde !");
            } else {
                Console.WriteLine("Boa Noite !");
            }
        }

    }
} 