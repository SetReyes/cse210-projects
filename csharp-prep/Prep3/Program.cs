using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaring variables
        int attempts = 1;
        int magic = 0;
        int guess = -1;
        string userInput = "yes";

        do
        {
            // Magic number
            Random randomGenerator = new Random();
            magic = randomGenerator.Next(1, 100);

            do
            {
                // Request for a guess
                Console.Write("What is your guess? ");
                string guessNumber = Console.ReadLine();
                guess = int.Parse(guessNumber);

                // Applying logic and giving promptings
                if (magic > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magic < guess)
                {
                    Console.WriteLine("Lower");
                }

                // Counting attempts
                attempts += 1;

            } while (magic != guess);

            // Showing attempts number & Asking user to continue playing or not
            Console.WriteLine($"You guessed it after {attempts} attempts!");
            Console.WriteLine("Do you want to continue? ");
            userInput = Console.ReadLine();
            attempts = 0;


        } while (userInput == "yes");
    }
}
