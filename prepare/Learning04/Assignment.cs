using System;

public class Assignment

{
    // variables
    protected string _studentName;
    private string _topic;

    // A constructor
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    // Behaviours or member functions
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }

}