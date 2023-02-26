using System;

public class Reflecting : Activity

{
    // Member variables
    public Random _random = new Random();

    private string[] _questionList = { "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
    private string[] _promtR = { "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};

    // A constructor
    public Reflecting() : base()
    {

    }

    // Behaviours or member functions
    public void GetPromptR()
    {
        int totalCount = _promtR.Count();
        int index = _random.Next(totalCount);
        string strPro = _promtR[index];
        Console.WriteLine("Consider the following prompt: \n");
        Console.WriteLine($" --- {strPro} --- \n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.Read();
    }

    public void RunReflecting() // Initiating reflection
    {
        Console.WriteLine("Now ponder in each of the following questions as they related to this experience.");
        CountdownDisplay("You may begin in: ", 5);
    }
    public void ReflectingProcess() // Listing pondering questions
    {
        double var = Math.Ceiling(_time / 10.0);
        int qNumber = Convert.ToInt32 (var);
        int ponderingTime = _time / qNumber;

        Console.Clear();
        for (int i = qNumber; i > 0; i--)
        {
            int totalCount = _questionList.Count();
            int index = _random.Next(totalCount);
            string strPro = _questionList[index];
            Console.Write($"> {strPro}");
            SpinnerDisplay(ponderingTime);
        }

    }
    
}
