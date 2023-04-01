using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

public class Reception : Event

{
    // Member variables
    private string _rsvp;

    // A constructor
    public Reception() : base()
    {
    }

    // Behaviours or member functions
    public string RunReception()
    {
        Console.Write("Indicate the RSVP email: ");
        _rsvp = Console.ReadLine();
        return $"Notify to: {_rsvp}\n";
    }
}
