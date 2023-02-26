using System;

public class Breathing : Activity

{
    // Member variables

    private string phaseOne = "Breathe in...";
    private string phaseTwo = "Breathe out...";
    private int _timeIn;
    private int _timeOut;

    // A constructor
    public Breathing() : base()
    {
    }
    // Behaviours or member functions
    public void RunBreathing(int time, int _timeIn = 2, int _timeOut = 3) // Example of the breathing exercise, creating fuction for future use bellow
    {
        Console.WriteLine();
        Console.Write(phaseOne);
        for (int i = _timeIn; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();
        Console.Write(phaseTwo);
        for (int i = _timeOut; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();


    }
    public void BreathingProcess() // Processing actual breathing exercise
    {
        int repeatingPeriod = _time / 10;
        int remainder = _time % 10;
        // Console.WriteLine();
        if (repeatingPeriod > 0)
        {
            for (int i = repeatingPeriod; i > 0; i--)
            {
                RunBreathing(_time, 4, 6);
            }

        }
        if (remainder > 0)
        {
            for (float i = 1; i > 0; i--)
            {
                int fractShort = remainder / 3;
                int fractLong = (remainder / 2 + remainder / 5);
                RunBreathing(_time, _timeIn = fractShort, _timeOut = fractLong);
            }

        }
    }

    public void BreathingStatistic() // Not complete yet
    {
        // int result = _statisticB.AsQueryable().Sum();

        foreach (int ele in _statisticB)
        {
            Console.WriteLine(ele);
        }
        // Console.WriteLine($"Breathing Stats: {result} seconds in the Breathing Activity");
    }
    public void DisplayStats() // Not complete yet
    {
        foreach (int item in _statisticB)
            Console.WriteLine($"{item}\n");
    }
}



