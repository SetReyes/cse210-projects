using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
public class Video
{
    // Instances
    Commment ClassCalling2 = new Commment();
    // variables
    public string _videoLength;
    public string _videoAuthor;
    public string _temporalString;
    public string _videoTittle;
    public string _video;
    public string[] _comments = {"Overcome the World and Find Rest;This man is so sweet; Golden Copper","Overcome the World and Find Rest;A beautiful, powerful, and hopeful message.; Kathy Karamanolis","Overcome the World and Find Rest;Thank you for blessing us with your powerful beautiful words; Sue Tate","Come, Thou Fount of Every Blessing;so perfect!!!!!!!!!!!!!; Cristão Declarado","Come, Thou Fount of Every Blessing;I cannot watch this at work.  I cry every time.; Marianne Hall","Come, Thou Fount of Every Blessing;Wow! I'm Muslim, and I felt that hymn.; Kibibi Siri","Josh Groban Mi Morena;Красиво! Ласково! Душевно! Великолепно!!!!;YulechkaZ","Josh Groban Mi Morena;Ele canta apaixonado, que lindo.;vilma helena", "Josh Groban Mi Morena;Josh,  he is one of the best, his voice is mesmerizing!;Renee Dipiazza", "Prelude-Love Is All;To me one of the most powerful songs;Jewls Orr", "Prelude-Love Is All;COMO EU AMOOO ESTA MÚSICA;Rosane Raiter", "Prelude-Love Is All;Una melodia che entra in te con un brivido indescrivibile;maurizio bonon", "Prelude-Love Is All;Rest in peace Vann Johnson;3abood2003"};
    public Dictionary<string, string> _videoInformation = new Dictionary<string, string>(){{"Overcome the World and Find Rest", "General Conference; 1123"},
            {"Come, Thou Fount of Every Blessing", "The Tabernacle Choir at Temple Square; 372"},
            {"Josh Groban Mi Morena", "Vicus55; 288"},{"Prelude-Love Is All", "Yanny; 502"}};

    // A constructor
    public Video()
    {
    }

    // Computing number of comments 
    public int GetCommentsNumber(string [] comments, string videoTittle)
    {
        // Counter initiation
        int _commentsNumber = 0;
        
        // Count when the comment belong to the video
        foreach (string comment in comments)
        {
            // Check if the video name if in the list item
            if (comment.Contains(videoTittle))
            {
                _commentsNumber++;
            }
        };
        return _commentsNumber;
    }

    // Display Videos Description
    public void DisplayVideo()
    {
        foreach (KeyValuePair<string, string> kvp in _videoInformation)
        {
            // Separating key from value in the dictionary
            (_videoTittle, _temporalString) = (kvp.Key, kvp.Value);
            string[] _temporalList = _temporalString.Split(';');
            

            // Assigning values to designated variables
            _videoAuthor = _temporalList[0];
            _videoLength = _temporalList[1];

            // Structuring Video inforamation
            _video = $"Title: {_videoTittle}\nAuthor: {_videoAuthor}\nLenght: {_videoLength}s\nNumber of comments: {GetCommentsNumber(_comments, _videoTittle)}\n\nComments are displayed below:";
            Console.WriteLine($"\n{_video}");

            // Adding video's comments to display with full video information
            ClassCalling2.VideoComments(_comments, _videoTittle);
        }

    }
}




