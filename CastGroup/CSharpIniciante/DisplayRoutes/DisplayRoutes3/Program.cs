using System;

namespace DisplayRoutes3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusRoute[] AllRoutes = BusRouteRepository.InitializeRoutes();

          
            Console.Write("Qual o destino: ");
            string location = Console.ReadLine();

            BusRoute route = FindBusTo(AllRoutes, location);
            Console.WriteLine("Destino selecionado: " + location);

            Console.WriteLine("-----------------------------------------");

            //Func<int, int> quadrado = x => x * x;
            //Console.WriteLine(quadrado(3));
            //int[] number = {2,3,4,5};
            //var squareNumbers = number.SetValue(x => x * x);
            //Console.WriteLine("-----------------------------------------");

            if (route != null)
            {
                Console.WriteLine("Pega o número: "  + route);
            } else
            {
                Console.WriteLine("Não tem busão para " + location) ;
            }

            
        }

        public static BusRoute FindBusTo(BusRoute[] route, string location)
        {
            //foreach (BusRoute item in route)
            //{
            //    if(item.Origin == location || item.Destination == location)
            //    {
            //        return item;
            //    }

            //}
            //return null;

            return Array.Find(route, routes => routes.Origin == location || routes.Destination == location);
        }
    }
}
