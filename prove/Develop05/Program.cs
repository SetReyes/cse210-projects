using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
namespace goals_book
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program Display lists
            List<Goals> _metas = new List<Goals>();
            int total = 0;
            int sel;
            do
            {
                // Instatiate SubClasses
                Simple SubCall1 = new Simple();
                Eternal SubCall2 = new Eternal();
                Check SubCall3 = new Check();

                // Show menu 
                Console.WriteLine($"\nYou have {total} points.\n");
                SubCall1.ShowMenu();
                sel = SubCall1.GetSelection();

                // Create new Goal 
                if (sel == 1)
                {
                    string type = SubCall1.GoalMenu();

                    // Simple
                    if (type == "1")
                    {
                        SubCall1.RecordGoal();
                        SubCall1.ForFileRecording();
                       
                        _metas.Add(SubCall1);
                    }
                    // Eternal
                    else if (type == "2")
                    {
                        SubCall2.RecordGoal();
                        SubCall2.ForFileRecording();
                       
                        _metas.Add(SubCall2);
                    }
                    // CheckList
                    else if (type == "3")
                    {
                        SubCall3.RecordGoal();
                        SubCall3.ForFileRecording();
                        
                        _metas.Add(SubCall3);
                    }
                }
                // Presenting results
                else if (sel == 2)
                {
                    int counter = 1;
                    Console.WriteLine("The goals are: ");
                    // List Goals
                    foreach (Goals item in _metas)
                    {
                        Console.WriteLine($"{counter}{item.GetGoals()}");
                        counter++;
                    }
                }
                // Save Goals 
                else if (sel == 3)
                {
                    // Requesting file's name
                    Console.Write("What is the name of the file? ");
                    string fileName = Console.ReadLine();

                    // Writing in the file
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        foreach (Goals item in _metas)
                        {
                            outputFile.WriteLine(item.GetSaveGoal());
                        }
                    }
                }
                // Load Goals
                else if (sel == 4)
                {
                    // Requesting file's name                   
                    Console.Write("What is the name of the file? ");
                    string _fileN = Console.ReadLine();

                    // Writing in the file
                    string[] lines = System.IO.File.ReadAllLines(_fileN);

                    foreach (string line in lines)
                    {
                        // Instatiate SubClasses
                        Simple SubCall4 = new Simple();
                        Eternal SubCall5 = new Eternal();
                        Check SubCall6 = new Check();

                        string[] parts1 = line.Split(":");
                        string[] parts = parts1[1].Split(",");

                        // Reorganize intances
                        if (parts1[0] == "SimpleGoal")
                        {
                            SubCall4.RecordEvent(parts[0], parts[1], parts[2]);
                            SubCall4.ForFileRecording();
                            _metas.Add(SubCall4);
                        }
                        else if (parts1[0] == "EternalGoal")
                        {
                            SubCall5.RecordEvent(parts[0], parts[1], parts[2]);
                            SubCall5.ForFileRecording();
                            _metas.Add(SubCall5);
                        }
                        else if (parts1[0] == "ChecklistGoal")
                        {
                            SubCall6.RecordEvent(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5]);
                            SubCall6.ForFileRecording();
                            _metas.Add(SubCall6);
                        }
                        else
                        {
                            Console.Write($"check again");
                        }

                    }
                }

                // Record Event
                else if (sel == 5)
                {
                    // Get the goal's points per accomplishment
                    Console.Write($"Which goal did you accomplish today? ");
                    int lineGoal = Convert.ToInt16(Console.ReadLine()) - 1;
                    int counter = 0;

                    // List Goals
                    foreach (Goals item in _metas)
                    {
                        string replaceLine = item.GetSaveGoal();

                        int valor = item.GetPointsPer();

                        if (counter == lineGoal)
                        {
                            total += valor;

                            // Do not know how to modify my goal status
                        }
                        counter++;
                    }
                }
            } while (sel != 6);
        }
    }
}