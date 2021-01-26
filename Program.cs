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
            Console.WriteLine("Welcome!");
            Console.WriteLine("Please Guess a number between 1-10.");
            Console.WriteLine("If it is right then you win, if not then you lose.");
            Random number = new Random();
            int randonNumber = number.Next(1, 10);
            Console.WriteLine(randonNumber);
        }
    }
}
