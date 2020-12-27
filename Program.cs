using System;

namespace NumberGuessingGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int winningNumber = randomNumber.Next(0, 50);
            bool wins = false;
            do
            {
                Console.Write("Guess a number inbetween 0 and 50: ");
                string inputNumber = Console.ReadLine();
                int intValue = int.Parse(inputNumber);
                if (intValue > winningNumber)
                {
                    Console.WriteLine("Too high! Guess lower.....");
                }
                else if (intValue < winningNumber)
                {
                    Console.WriteLine("Go low!  Guess higher.....");
                }
                else if (intValue == winningNumber)
                {
                    Console.WriteLine("YOU WIN!!!");
                    wins = true;
                }
            } while (wins == false);
            Console.WriteLine("Thank you for playing the game!");
            Console.WriteLine("Press any key to finish");
            Console.ReadLine();
        }
        
    }
}