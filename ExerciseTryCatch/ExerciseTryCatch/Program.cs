using ExerciseTryCatch.Entities;

namespace ExerciseTryCatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Room Number");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (DD/MM/YYYY): ");
            DateTime ckeckIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (DD/MM/YYYY): ");
            DateTime ckeckOut = DateTime.Parse(Console.ReadLine());

            
            Reservation reservation = new Reservation(number, ckeckIn, ckeckOut);

        }
    }
}