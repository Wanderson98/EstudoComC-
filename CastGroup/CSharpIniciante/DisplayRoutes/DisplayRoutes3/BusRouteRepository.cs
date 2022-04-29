using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayRoutes3
{
    internal class BusRouteRepository
    {

        public static BusRoute[] InitializeRoutes()
        {
            return new BusRoute[]
            {
                new BusRoute (345, "Anchieta", "Praça da Bandeira"),
                new BusRoute (274, "Juventude", "Praça da Igreja"),
                new BusRoute (345, "Central", "Rua Bandeirante"),
                new BusRoute (345, "Central", "Siqueira Campos"),
                new BusRoute (345, "Cajueiro", "Farol da Barra")
            };
        }
    }
}
