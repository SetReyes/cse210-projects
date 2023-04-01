using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

public class Outdoor : Event

{
    // Member variables
    private string _weatherForcast;
    
    // A constructor
    public Outdoor()
    { }

    // Behaviours or member functions
    public string RunOutdoor()
    {
        Console.Write("Expected Weather Conditions: ");
        _weatherForcast = Console.ReadLine();
        
        return $"Weather Forcast: {_weatherForcast}\n";
    }
}


