using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaring variables
        int number = -1;
        List<int> numbers = new List<int>();
        List<int> positive = new List<int>();

        // Instructions
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        // Loop to add numbers
        do
        {   // Converting each number into an integer
            Console.Write("Enter number: ");
            string inputNumber = Console.ReadLine();
            number = int.Parse(inputNumber);

            // Appending number to the lists
            if (number != 0)
                numbers.Add(number);
            if (number > 0)
                positive.Add(number);

        } while (number != 0);

        // Adding list's numbers:
        int result = numbers.AsQueryable().Sum();

        // Getting list's average number:
        decimal countItems = numbers.Count();
        decimal aveNumber = (result / countItems);

        // Another way to get the average with decimal
        // float aveNumber = ((float)result) / numbers.Count;
        // Console.WriteLine($"The average is: {aveNumber}");

        //List's max & min pos (two ways)
        int minPos = positive.AsQueryable().Min();
        int max = numbers.Max();

        // Sorted list
        numbers.Sort();

        // Presenting Results:
        Console.WriteLine("The sum is: {0}", result);
        Console.WriteLine(String.Format("The average is: {0:0.###}", aveNumber));
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {minPos}");
        Console.WriteLine($"The sorted list is:");
        foreach (int ele in numbers)
        {
            Console.WriteLine(ele);
        }

    }
}
