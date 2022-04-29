using System;

namespace Aula32
{   /*interface 
     
     */
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Porco porco = new Porco();
            Gato gato = new Gato();
            Cachorro cachorro = new Cachorro();

            porco.somDoAnimal();
            gato.somDoAnimal();
            cachorro.somDoAnimal();
        }
    }
    interface IAnimal
    {   // o metodo da classe pai substitui o metodo da filha caso tenham o mesmo nome 
        void somDoAnimal();
      
    }
    //classes filhas
    class Cachorro : IAnimal
    {
        public void somDoAnimal()
        {
            Console.WriteLine("Cachorro faz Auau");
        }
    }
    class Porco : IAnimal
    {
        public void somDoAnimal()
        {
            Console.WriteLine("Porco faz ronkronk");
        }
    }

    class Gato : IAnimal
    {
        public void somDoAnimal()
        {
            Console.WriteLine("Gato faz miau miau");
        }

    }
}
