using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Commment
{
    // Member variables
    private string _commentText;
    private string _commentAuthor;

    // Constructor
    public Commment()
    {
    }
    // Member functions
    public void VideoComments(string[] comments, string videoTittle)
    {
        // Enumerate comments
        int _counter = 1; 
        
        // Organize comments text with their respective authors
        foreach (string comment in comments)
        {
            // Split list item into separate variables
            string[] _temporalList = comment.Split(';');
            _commentText = _temporalList[1];
            _commentAuthor = _temporalList[2];
            
            // Displaying comment text and author     
            if (_temporalList[0] == videoTittle)
            {
                Console.WriteLine($"{_counter}. {_commentText} \nAuthor: {_commentAuthor}");
                _counter++;
            }
        }
    }
}