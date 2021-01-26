using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("Please Guess a number between 1-10.");
            Console.WriteLine("If it is right then you win, if not then you lose.");

            int userNumber = Convert.ToInt32(Console.ReadLine());
            Random number = new Random();
            //int randomNumber = number.Next(1, 10);
            int testNumber = 7;

            if (userNumber == testNumber)
                Console.WriteLine("You Won!");

            else if (userNumber != testNumber && userNumber != 0 && userNumber != -1)
                Console.WriteLine("Try Again.");

            else if (userNumber == 0)
            {
                Console.WriteLine("Please Guess a number between 1-10.");
                Console.WriteLine("If it is right then you win, if not then you lose.");
            }
            else if (userNumber == -1) 
            {
               Console.WriteLine("That is does not follow the rules, Goodbye.");
                
            }

        }   

    }
}
