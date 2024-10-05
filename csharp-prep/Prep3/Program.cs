using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes"; // Variable to track if the user wants to play again

        while (playAgain.ToLower() == "yes") // Loop for restarting the game
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;

            // Main game loop
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You did it!");
                }
            }

            // Stretch Challenge
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        // Stretch Challenge
        Console.WriteLine("Thank you for playing!");
    }
}