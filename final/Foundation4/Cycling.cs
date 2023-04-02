using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace  Activity_book
{
    public class Cycling :  Activity

    {  
        // A constructor
        public Cycling() : base()
        {
        }
        // Member Functions
        public override string RecordActivity(string type = "Cycling")
        {
            {   
                Console.WriteLine($"\nPlease, input the following data: ");
                Console.Write("Date (DD MMM YYYY): ");
                _date = Console.ReadLine();
                Console.Write($"Time(min): ");
                _timeLength = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Distance(km): ");
                _distance = Convert.ToDouble(Console.ReadLine());              
                _speed = Math.Round((_distance/_timeLength)*60,1); // kph
                _pace = Math.Round(_timeLength/_distance,1); // min per km
                _displayList = $" {_date} {type} ({_timeLength} min): Distance {_distance} km, Speed {_speed} kph, Pace: {_pace} min per km";
            }
            return _displayList;
        }
        
        public override double GetDistance() // km 
        {
            return _distance;
        }
        public override double GetSpeed() // km/hr
        {        
            return _speed;
        }
        public override double GetPace() // min/km
        {
            return _distance;
        }
    }
}

