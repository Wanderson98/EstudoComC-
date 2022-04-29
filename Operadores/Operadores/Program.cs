namespace Operadores {

    class Program {
        static void Main(string[] args) {

            //Operadores comparativos
            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 30;
            bool c4 = a > 5;

            Console.WriteLine(c1); //false
            Console.WriteLine(c2); // true
            Console.WriteLine(c3); //false
            Console.WriteLine(c4); //true

            Console.WriteLine("--------------------------------");

            bool c5 = a <= 10; //true
            bool c6 = a >= 10; //true
            bool c7 = a == 10; //true
            bool c8 = a != 10; //false


            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);

            Console.WriteLine("--------------------------------");

            //comparadores logicos(&& e), (|| ou), (! nao )

            bool b1 = 4 != 5;
            bool b2 = 2 > 3 && 4 != 5;
            bool b3 = 2 > 3 || 4 != 5;
            bool b4 = !(2 > 3) || 4 != 5;
            bool b5 = !(2 > 3) && 4 != 5;


            Console.WriteLine(b1); //true
            Console.WriteLine(b2); //false
            Console.WriteLine(b3); //true
            Console.WriteLine(b4); //true
            Console.WriteLine(b5); //true
            Console.WriteLine("--------------------------------");
             
            bool d1 = 10 < 5; //false
            bool d2 = b3 ||  b5 && d1; //true


            Console.WriteLine(d1);
            Console.WriteLine(d2);




        }
    }
}