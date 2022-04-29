using System;

namespace DisplayRoutes4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusRoute[] AllRoutes = BusRouteRepository.InitializeRoutes();


            Console.Write("Qual o destino: ");
            string location = Console.ReadLine().ToLower();

            BusRoute[] route = FindBusesTo(AllRoutes, location);
            Console.WriteLine("Destino selecionado: " + location);

            Console.WriteLine("-----------------------------------------");

            //Func<int, int> quadrado = x => x * x;
            //Console.WriteLine(quadrado(3));
            //int[] number = {2,3,4,5};
            //var squareNumbers = number.SetValue(x => x * x);
            //Console.WriteLine("-----------------------------------------");

            if(route != null)
            {
                foreach (BusRoute item in route)
                {
                    Console.WriteLine(item.ToString());
                }
            }

        }

        public static BusRoute[] FindBusesTo(BusRoute[] routes, string location)
        {
            //foreach (BusRoute item in route)
            //{
            //    if(item.Origin == location || item.Destination == location)
            //    {
            //        return item;
            //    }

            //}
            //return null;

            return Array.FindAll(routes, route => route.Servers(location));
        }
    }
}
