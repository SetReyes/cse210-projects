using System;

public class Enumeration : Activity

{
    // Member variables
    public Random _random = new Random();
    public string varTemp;

    private string[] _promtE = { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    protected int _items;


    // A constructor
    public Enumeration()
    { }

    // Behaviours or member functions
    protected string GetPromptE(string[] array)
    {
        int totalCount = array.Count();
        int index = _random.Next(totalCount);
        string strPro = array[index];
        return strPro;
    }

    public void RunEnumeration() // Initiate listing
    {
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($" ---  {GetPromptE(_promtE)} --- ");
        CountdownDisplay("You may begin in: ", 5);

    }
    public void EnumerationProcess() // Listing all experiences
    {

        Console.WriteLine();
        DateTime initialTime = DateTime.Now;
        DateTime endTime = initialTime.AddSeconds(_time);
        Console.WriteLine(initialTime);
        Console.WriteLine(endTime);
        while (DateTime.Now < endTime)
        {
            if (DateTime.Now < endTime)
            {
                Console.Write("> ");
                varTemp = Console.ReadLine();
            }
        }
    }
}


