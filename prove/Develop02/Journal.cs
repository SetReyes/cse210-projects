using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
public class Journal
{
    // variables
    public string _fileName;
    public int sel = 0;
    public string jEntry;
    public string[] _addText = Array.Empty<string>();
    public string _pText;
    public string _dText;
    public DateTime theCurrentTime = DateTime.Now;
    public string _futText = "";

    // A constructor
    public Journal()
    {
    }

    // Joining the date, the prompt, and the answer 
    public void CompleteEntry()
    {
        string _dText = theCurrentTime.ToShortDateString();
        Console.WriteLine($"{_pText}");
        string answer = Console.ReadLine();
        jEntry = "Date: " + _dText + " - Prompt: " + _pText + "\n" + answer;
        _addText = _addText.Append(jEntry).ToArray();
    }

    // Display journal entries
    public void DisplayJournal()
    {
        foreach (string item in _addText)
            Console.WriteLine($"{item}\n");
    }
    // Loading entries
    public void LoadEntries()
    {
        Console.WriteLine("What is the name of the file? ");
        string _fileN = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_fileN);
        // Array.Clear(_addText);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            _addText = _addText.Append(line).ToArray();
        }
    }

    // Saving entries
    public void SaveEntries()
    {

        Console.WriteLine("What is the name of the file? ");
        _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            // You can add text to the file with the WriteLine method
            foreach (string item in _addText)
                outputFile.WriteLine(item);
        }
    }
}





