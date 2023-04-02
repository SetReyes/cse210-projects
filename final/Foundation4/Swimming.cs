using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
namespace Activity_book
{
    public class Swimming : Activity

    {
        // variables
        private double _laps;
        private double _LAPLENGTH = 50; //in meters

        // A constructor
        public Swimming() : base()
        { }

        // Member Functions
        public override string RecordActivity(string type = "Swimming")
        {
            {
                Console.WriteLine($"\nPlease, input the following data: ");
                Console.Write("Date (DD MMM YYYY): ");
                _date = Console.ReadLine();
                Console.Write($"Time(min): ");
                _timeLength = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Number of laps: ");
                _laps = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Distance(km): ");
                _distance = Math.Round((_laps * _LAPLENGTH) / 1000, 2);
                _speed = Math.Round((_distance / _timeLength) * 60, 2); // kph
                _pace = Math.Round(_timeLength / _distance, 1); // min per km
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
            return _pace;
        }
        public double GetLaps() // km/min
        {
            return _laps;
        }
    }
}

