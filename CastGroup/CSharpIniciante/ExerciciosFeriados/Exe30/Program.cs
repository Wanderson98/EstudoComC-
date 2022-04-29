using System;
using System.Collections.Generic;

namespace Exe30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>();
            num.Add(2);
            num.Add(1);
            num.Add(8);
            num.Add(7);
            num.Add(5);

            num.Sort();

            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }
    }
}
