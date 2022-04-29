using System;

namespace Aula31
{
    internal class Program
    {   //classe pai

        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Animal porco = new Porco();
            Animal gato = new Gato();
            Animal cachorro = new Cachorro();

            animal.somDoAnimal();
            porco.somDoAnimal();
            gato.somDoAnimal();
            cachorro.somDoAnimal();
        }
    }
    class Animal
    {   // o metodo da classe pai substitui o metodo da filha caso tenham o mesmo nome
        public virtual void somDoAnimal()
        {
            Console.WriteLine("O animal faz o som: ");
        }
    }
    //classes filhas
    class Cachorro : Animal
    {
        public override void somDoAnimal()
        {
            Console.WriteLine("Cachorro faz Auau");
        }
    }
    class Porco : Animal
    {
        public override void somDoAnimal()
        {
            Console.WriteLine("Porco faz ronkronk");
        }
    }

    class Gato : Animal
    {
        public override void somDoAnimal()
        {
            Console.WriteLine("Gato faz miau miau");
        }

    }
}
