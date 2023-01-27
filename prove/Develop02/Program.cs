using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(string[] args)
    {

        // Variables
        int option = 0;
        // var addText = Array.Empty<string>();

        // instantiations
        Journal JouClass = new Journal();
        Iteration mySelection = new Iteration();

        // Initial message
        Console.Write("Welcome to you Journal!");

        while (option != 5)
        {
            // Displaying menu
            Iteration myOption = new Iteration();
            myOption.ShowMenu();

            // Obtaining selection number
            option = mySelection.OptionSelection();

            // Applying conditions

            // Writing an entry
            if (option == 1)
            {
                // Iteration to get a random prompt                 
                string promptText = mySelection.RandomPrompt();
                // Processing journal writing request (option 1)
                JouClass._pText = promptText;
                JouClass.CompleteEntry();
            }

            // Displaying all entries
            else if (option == 2)
            {
                JouClass.DisplayJournal();
            }

            // Loading entries from a file
            else if (option == 3)
            {
                JouClass.LoadEntries();
            }
            
            // Saving entries in a file
            else if (option == 4)
            {
                JouClass.SaveEntries();
            }
            else if (option == 5)
            {
                Console.WriteLine("Do you really want to quit?(y/n): ");
                string finalAnswer = Console.ReadLine();
                if (finalAnswer != "y")
                {
                    option = 0;
                }
                else
                {
                    option = 5;
                }

            }
            else
            {
                Console.WriteLine("You have input an invalid option");

            }
        }

    }

    // string[] SendList()
    //     {
    //         string[] _send = addText;
    //         return _send;
    //     }

    // // Display all entries stored in the array
    // public static void AsSpan(string[] array)
    // {
    //     //Display all entries stored in the array
    //     foreach (var item in array)
    //         Console.WriteLine(item);
    // }
    // // Adding text entry to empty list
    // public string[] AppendEntry()
    // {
    //     entries = entries.Append(_futText).ToArray();
    //     var jourEnt = entries.ToArray();
    //     return jourEnt;

    // }
    // var entries = Array.Empty<string>();
    // entries = entries.Append(fullEntry).ToArray();
    // var jourEnt = entries.ToArray();


    // Array.ForEach(entries, Console.WriteLine);

    //Display all entries stored in the array
    // foreach (var item in addText)
    //     Console.WriteLine(item);}

    // Entry AddEntry = new Entry();
    // AddEntry._futText = fullEntry;
    // addText = AddEntry.AppendEntry();



    // """public class Entry
    // {
    //     // variables
    //     public string _pText;
    //     public string _dText;
    //     // public string _displayEntry;
    //     public DateTime theCurrentTime = DateTime.Now;
    //     public string _futText = "";

    //     public int sel = 0;

    //     // A constructor
    //     public Entry()
    //     {
    //     }
    //     // Joining the date, the prompt, and the answer 
    //     public string CompleteEntry()
    //     {
    //         string _dText = theCurrentTime.ToShortDateString();
    //         Console.WriteLine($"{_pText}");
    //         string answer = Console.ReadLine();
    //         string jEntry = "Date: " + _dText + " - Prompt: " + _pText + "\n" + answer;
    //         return jEntry;
    //     }

    // } """
}