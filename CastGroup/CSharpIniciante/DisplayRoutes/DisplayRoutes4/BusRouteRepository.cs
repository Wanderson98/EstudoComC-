using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayRoutes4
{
    internal class BusRouteRepository
    {

        public static BusRoute[] InitializeRoutes()
        {
            return new BusRoute[]
            {
                new BusRoute (345,new string[] 
                { "Anchieta".ToLower(), "Deodoro".ToLower(), "Mal Hermes".ToLower(), "Praça da Bandeira".ToLower() }),
                new BusRoute (274,new string[]
                { "Juventude".ToLower(), "Faria Campos".ToLower(), "Governador Rui Alves".ToLower(), "Praça da Igreja".ToLower()}),
                new BusRoute (765,new string[]
                { "Central".ToLower(), "Praia do Flamengo".ToLower(), "Copacabana".ToLower(), "Rua Bandeirante".ToLower()}),
                new BusRoute (957,new string[]
                { "Central".ToLower(),"Rio Mar".ToLower(), "Ipanema".ToLower(), "El Alvorado".ToLower(), "Copacabana".ToLower(), "Siqueira Campos".ToLower()}),
                new BusRoute (572,new string[] 
                { "Cajueiro".ToLower(), "Lagoa".ToLower(), "Gavea".ToLower(), "Praia do Flamengo".ToLower(),  "Farol da Barra".ToLower()})
            };
        }
    }
}
