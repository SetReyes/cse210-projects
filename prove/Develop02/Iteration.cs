using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Iteration
{
    // Member variables
    public Random _random = new Random();

    // List of prmpts
    public string[] _prompts = { "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "What places have you been today?" };

    public int sel = 0;

    // Constructor
    public Iteration()
    {
    }
    // Random selection of prompt
    public string RandomPrompt()
    {

        int totalCount = _prompts.Count();
        int index = _random.Next(totalCount);
        string strPro = _prompts[index];
        return strPro;
    }
    // Present the available options
    public void ShowMenu()
    {

        Console.Write("Please, select one of the following: \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit \nWhat would you like to do? ");

    }
    // Processing selection number
    public int OptionSelection()
    {
        sel = Convert.ToInt32(Console.ReadLine());
        return sel;
    }

}