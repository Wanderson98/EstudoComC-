using System.Globalization;

namespace EntradaDeDados {

    class Program {
        static void Main(string[] args) {

             string frase = Console.ReadLine();
             string x = Console.ReadLine();
             string y = Console.ReadLine();
             string z = Console.ReadLine();


             string[] vet = Console.ReadLine().Split(' ');

             Console.WriteLine("Você digitou:  ");
             Console.WriteLine(frase);
             Console.WriteLine(x);
             Console.WriteLine(y);
             Console.WriteLine(z);

             for (int i = 0; i < vet.Length; i++) {
                 Console.WriteLine(vet[i]);
             }
            
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            string[] vet1 = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


            Console.WriteLine("você digitou");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome + " " + sexo + " " + idade + " " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}