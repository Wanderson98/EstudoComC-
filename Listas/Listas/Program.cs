﻿
namespace Listas {

    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            list.Insert(2, "Marco");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List.Count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro letra A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo letra A: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posicao do primeiro com A: " + pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Posicao do ultimo com A: " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5) ;
            Console.WriteLine("------------------------------");

            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("------------------------------");
            list.Remove("Alex");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("------------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------");
            list.RemoveAt(1);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------");
            list.RemoveRange(0, 1);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine(list.Count);

        }
    }

}