using System;

public class WritingAssignment : Assignment

{
    // variables
    private string _title;

    // A constructor
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }
    // Behaviours or member functions
    public string GetWritingInformation()
    {
        return _title + " by " + _studentName;
    }

}