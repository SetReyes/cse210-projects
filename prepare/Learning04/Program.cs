using System;

class Program
{
    static void Main(string[] args)
    {
        //Super Class
        Assignment testCall = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine();
        Console.WriteLine(testCall.GetSummary());

        //Sub Classes
        MathAssignment testCall1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine();
        Console.WriteLine(testCall1.GetSummary());
        Console.WriteLine(testCall1.GetHomeworkList());

        WritingAssignment testCall2 = new WritingAssignment("Mary Waters", "European History", "The CAuses of World War II");
        Console.WriteLine();
        Console.WriteLine(testCall2.GetSummary());
        Console.WriteLine(testCall2.GetWritingInformation());
        Console.WriteLine();
    }
}