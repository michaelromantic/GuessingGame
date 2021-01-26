using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hopefully This Works");
            //Console.WriteLine("Hopefully this DOESN'T WORK!");

            Random number = new Random();
            int randonNumber = number.Next(1, 500);
            Console.WriteLine(randonNumber);
        }
    }
}
