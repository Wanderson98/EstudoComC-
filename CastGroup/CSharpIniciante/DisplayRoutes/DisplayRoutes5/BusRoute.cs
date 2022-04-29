using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayRoutes5
{
 
    internal class BusRoute
    {
        public int Number { get; }
        public string Origin => PlacedServed[0];
        public string Destination => PlacedServed[^1];
        public string[] PlacedServed { get; }

        //public BusRoute(int number, string origin, string[] placedServed, string destination)
        //{
        //    Number = number;
        //    Origin = origin;
        //    Destination = destination;
        //}

        public BusRoute(int number, string[] placedServed)
        {
            Number = number;
            PlacedServed = placedServed;
        }

        public bool Servers(string destination)
        {
            foreach (string place in PlacedServed)
            {
                if (place == destination)
                {
                    return true;
                }
            }
            return false;
        }

        // => expressão lambda 
        public override string ToString() => $"{Number}: {Origin} -> {Destination}";

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
