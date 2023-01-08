using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        String name = Console.ReadLine();
        Console.Write("What is your last name? ");
        String surname = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Your name is {surname}, {name} {surname}.");
    }
}