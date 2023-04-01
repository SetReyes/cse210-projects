using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

public class Event
{
    // variables
    protected string _eventType;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    // Instances
    Address addressCall = new Address();

    // A constructor
    public Event()
    {
    }
    // Behaviours or member functions
    public string StandardEvent()
    {
        return $"\nStandard Message\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\n";
    }
    public string FullDetails(string extra = "")
    {
        return $"\nFull Message\nEvent Type: {_eventType}\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\n{extra}";
    }
    public string ShortDescription()
    {
        return $"\nShort Message\nEvent: {_eventType}\nTitle: {_title}\nDate: {_date}\n";
    }
    public void SetEventData(string selection1)
    {
        Console.WriteLine("\nDefine Event Parameters ");
        Console.Write("Title: ");
        _title = Console.ReadLine();
        Console.Write("Description: ");
        _description = Console.ReadLine();
        Console.Write("Date (DD-MM-YYYY): ");
        _date = Console.ReadLine();
        Console.Write("Time (HH:MM XM): ");
        _time = Console.ReadLine();
        _address = addressCall.FullAddress();
        if (selection1 == "1")
        {
            _eventType = "Outdoor";
        }
        else if (selection1 == "2")
        {
            _eventType = "Lecture";
        }
        else if (selection1 == "3")
        {
            _eventType = "Reception";
        }
    }
    public int DisplayChoice()
    {
        Console.WriteLine("\nMessage Type Menu: ");
        Console.WriteLine("1. Standard Message ");
        Console.WriteLine("2. Full Message ");
        Console.WriteLine("3. Short Message ");
        Console.Write("Display Message Choice: ");
        int _choice = Convert.ToInt16(Console.ReadLine());
        return _choice;
    }
}