using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

public class Lecture : Event

{
    // Member variables
    private string _speakerName;
    private string _capacity;
    // A constructor
    public Lecture() : base()
    {
    }
    // Behaviours or member functions
    public string RunLecture()
    {
        Console.Write("Indicate Lecture Speaker Name: ");
        _speakerName = Console.ReadLine();
        Console.Write("Indicate Lecture Room Capacity: ");
        _capacity = Console.ReadLine();
        return $"Lecture Speaker: {_speakerName}\nRoom Capacity: {_capacity}\n";
    }
}

     