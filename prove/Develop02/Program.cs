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
}