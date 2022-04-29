using System;
using System.Collections.Generic;

namespace DisplayRoutes5
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            List<BusRoute> allRoutes = BusRouteRepository.InitializeRoutes();

           Console.WriteLine($"\nExistem: {allRoutes.Count} rotas");

            foreach (BusRoute route in allRoutes)
            {
                Console.WriteLine(route);
            }

            //allRoutes.RemoveAt(3);

            Console.WriteLine($"\nExistem agora: {allRoutes.Count} rotas");
            foreach (BusRoute route in allRoutes)
            {
                Console.WriteLine(route);
            }


        }



    }
}
