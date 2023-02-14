using System;

class Program
{
    static void Main(string[] args)
    {
                int sum = 0;
        int i = 0;
        string[] cases = { "A", "B", "A", "B", "A", "B", "A", "B" };
        Console.WriteLine("    " + " Count " + "Sum");

        for (int count = 1; count < 9; count *= 2)         // A
        {
            
            Console.WriteLine(cases[i] + "     " + count + "     " + sum);
            sum += count; // B
            Console.WriteLine(cases[i + 1] + "     " + count + "     " + sum);
        }
    }
}