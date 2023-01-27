using System;
using System.Collections.Generic;

public class Iteration
{
    // Member variables
    public Random _random = new Random();

    public string[] _prompts = { "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "What places have you been today?" };

    public int sel = 0;

    // A special method, called a constructor that is invoked using the  new keyword followed by the class name and parentheses.
    public Iteration()
    {
    }
    public string RandomPrompt()
    {
        // Random selection of prompt
        int totalCount = _prompts.Count();
        int index = _random.Next(totalCount);
        string strPro = _prompts[index];
        return strPro;
    }
    public void ShowMenu()
    {
        // Present the available options
        Console.Write("Please, select one of the following: \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit \nWhat would you like to do? ");
        // int selection = _option;
        // return selection;

    }
    public int OptionSelection()
    {
        sel = Convert.ToInt32(Console.ReadLine());
        return sel;
    }

}