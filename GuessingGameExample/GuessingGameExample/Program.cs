using System;

namespace GuessingGameExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numToGuess = random.Next(1, 100); // these two lines are used for random number generation
            Console.WriteLine("What number am I thinking of?");
            bool isGameRunning = true;
            while (isGameRunning) {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input > numToGuess)
                {
                    Console.WriteLine("Too high!");
                } else if (input < numToGuess)
                {
                    Console.WriteLine("Too low!");
                } else {
                    Console.WriteLine("You Win!");
                    Console.WriteLine("Enter 'y' to Play Again!");
                    string playAgain = Console.ReadLine().ToLower();
                    if(playAgain.Equals("y")) // for this case, can be used in place of playAgain == "y"
                    {
                       Console.WriteLine("What number am I thinking of?");
                       numToGuess = random.Next(1, 100);
                    } else
                    {
                       isGameRunning = false;
                    }
                }
            }
        }
    }
}
