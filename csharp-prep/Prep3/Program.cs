using System;

class Program
{
    static void Main(string[] args)
    {
        // Magic number
        // Random randomGenerator = new Random();
        // int magic = randomGenerator.Next(1, 100);

        // Console.Write("What is the magic number? "); string magicNumber = Console.ReadLine(); int magic = int.Parse(magicNumber);



        // Declaring variables
        int attempts = 1;
        int magic = 0;
        int guess = 1;

        // Compare magic number with guess number
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

                // Applying logic to guess magic number
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

            Console.WriteLine($"You guessed it after {attempts} attempts!");
            Console.WriteLine("Do you want to continue? ");
            userInput = Console.ReadLine();
            attempts = 0;


        } while (userInput == "yes");
    }
}
