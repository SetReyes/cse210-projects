using System;

public class Activity
{
    // variables
    private string _messageOne;
    private string _descriptionMesssage;
    protected int _time;
    private string[] spinnerStrings = { "|", "/", "-", "\\", "|", "/", "-", "\\" };
    private string _activity;
    protected List<int> _statisticB = new List<int>();
    protected string[] _statisticR = Array.Empty<string>();
    protected string[] _statisticE = Array.Empty<string>();

    // A constructor
    public Activity()
    {
    }
    // Behaviours or member functions
    public string SelectionCall(string selection)
    {
        if (selection == "1")
            _activity = "Breathing";
        else if (selection == "2")
            _activity = "Reflecting";
        else if (selection == "3")
            _activity = "Listing";
        Console.Clear();
        _messageOne = "Welcome to the " + _activity + " Activity";
        return _messageOne;

    }
    public string MessageDisplay(string selection)
    {
        Console.WriteLine();
        if (selection == "1")
            _descriptionMesssage = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        else if (selection == "2")
            _descriptionMesssage = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        else if (selection == "3")
            _descriptionMesssage = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        return _descriptionMesssage;
    }
    public void TimeRequest()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string time = Console.ReadLine();
        _time = int.Parse(time);
        Console.Clear();
        Console.WriteLine("Get Ready...");
        SpinnerDisplay();

        // if (_activity == "Breathing")
        //    _statisticB.Add(_time);
        // if (_activity == "Reflecting") 
        // { _statisticR.Add(_time); }
        // if (_activity == "Listing")
        // { _statisticE.Add(_time); }

    }
    public int GetTime()
    {
        return _time;
    }
    public void CountdownDisplay(string message, int runningTime)
    {

        Console.Write(message);
        for (int i = runningTime; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void SpinnerDisplay(int waiting = 5)
    {

        int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(waiting);
        while (DateTime.Now < endTime)
        {
            string s = spinnerStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= spinnerStrings.Length)
            {
                i = 0;
            }
        }
        Console.WriteLine();

    }
    public void FinalMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!!");
        SpinnerDisplay();

        Console.WriteLine($"You have completed another {_time} seconds of {_activity} Activity.");
        SpinnerDisplay();
    }




}