using System;

namespace DisplayRoutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusRoute route3030 = new BusRoute(3030, "Horizonte Novo", "Pedra Vermelha");
            BusRoute route5655 = new BusRoute(5655, "Rua das Flores", "Estaçao Primavera");

            BusRoute[] routes =
            {
                route3030,
                route5655,
                new BusRoute(5543, "Praça da Juventude", "Jeremoabo"),
                new BusRoute(2234, "Consolação", "Praça da Purificação")


            };

            foreach (BusRoute route in routes)
            {
                Console.WriteLine(route);
            }
            
            //Console.WriteLine(route3030);
            //Console.WriteLine(route5655);
        }
    }
}
