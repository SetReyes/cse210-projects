using System;

public class Event
{
    // variables
    protected string _tittle;
    protected string _description;
    protected int _date;
    protected double _time;
    protected string _address;
    
    // protected List<int> _statisticB = new List<int>();
    // protected string[] _statisticE = Array.Empty<string>();
    // private string[] spinnerStrings = { "|", "/", "-", "\\", "|", "/", "-", "\\" };

    // A constructor
    public Event()
    {
    }
    // Behaviours or member functions
    public string StandardEvent()
    {
        return " Event";
    }
    public string ShortEvent()
    {
        return " Event";
    }   
    public string FullEvent()
    {
        return " Event";
    }
}