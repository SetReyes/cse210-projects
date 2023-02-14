using System;

public class MathAssignment : Assignment

{
    // variables
    private string _textbookSection;
    private string _problems;

    // A constructor
    public MathAssignment(string name, string topic, string textbooksection, string problems) : base(name, topic)
    {
        _textbookSection = textbooksection;
        _problems = problems;
    }
     // Behaviours or member functions
    public string GetHomeworkList()
    {
        return "Section " + _textbookSection + "Problems " + _problems;
    }
}