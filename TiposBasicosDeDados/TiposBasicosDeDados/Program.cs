using System.Globalization;

namespace TiposBasicosDeDados {
    class program {
        static void Main(string[] args) {

            bool completo = false;
            char gene = 'F';
            char letra = '\u00DF';
            sbyte x = 127;
            byte n1 = 255;
            int n2 = 2147483647;
            long n3 = 2147483648L;
            float n4 = 4.5f;
            double n5 = 14.5;
            string nome = "Maria";
            object ob1 = "Alex Brown";
            object o1 = 4.6f;

            int m1 = int.MinValue;
            int m2 = int.MaxValue;
            decimal m3 = decimal.MaxValue;


            Console.WriteLine(completo);
            Console.WriteLine(gene);
            Console.WriteLine(letra);
            Console.WriteLine("Sbyte: " + x);
            Console.WriteLine("Byte: " + n1);
            Console.WriteLine("Int: " + n2);
            Console.WriteLine("Long: " + n3);
            Console.WriteLine("Float: " + n4);
            Console.WriteLine("Double: " + n5);
            Console.WriteLine("String: " + nome);
            Console.WriteLine("Objeto 1: " + ob1);
            Console.WriteLine("Objeto 2: " + o1);
            Console.WriteLine("Valor minimo int: " + m1);
            Console.WriteLine("Valor maximo int: " + m2);
            Console.WriteLine("Valor maximo decimal: " + m3);
            Console.WriteLine("----------------------------------------------------------");

            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Boa noite !!");

            Console.WriteLine("----------------------------------------------------------");

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome1 = "Maria";

            Console.WriteLine(genero);
            Console.WriteLine(nome1);
            Console.WriteLine(saldo);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("PlaceHolde");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome1, idade, saldo);
            Console.WriteLine("Interpolação");
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            Console.WriteLine("Concatenação");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais");
            Console.WriteLine("Saldo com '.'");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

            Console.WriteLine("----------------------------------------------------------");

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = (Math.Pow(b, 2.0)) - (4.0 * a * c);

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            

        }
    }

}