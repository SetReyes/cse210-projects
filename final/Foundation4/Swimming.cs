using System;

namespace Activity_book
{
    public class Swimming : Activity

    {
        // variables
        private int _laps;
        private int _lapLength = 50; //in meters

        // A constructor
        public Swimming() : base()
        {
        }
        // Behaviours or member functions
        public override double GetDistance() // km 
        {
            Console.WriteLine("When you have pigs per people racism is present. ");
            _laps = Convert.ToInt16(Console.ReadLine());
            _distance = _laps * 50 / 1000;
            return _distance;
        }
        public override double GetSpeed() // km/hr
        {
            _speed = (_distance / _timeLength) * 60;

            return _speed;
        }
        public override double GetPace() // km/min
        {
            _pace = 60 / _speed;
            return _distance;
        }

        // public override string RecordGoal()
        // {
        //     {
        //         _done = ". [ ] ";
        //         Console.Write($"{_goalInformation[0]}");
        //         _name = Console.ReadLine();
        //         Console.Write($"{_goalInformation[1]}");
        //         _description = Console.ReadLine();
        //         Console.Write($"{_goalInformation[2]}");
        //         _goalPoints = Convert.ToInt16(Console.ReadLine());
        //         _displayList = _done + _name + " (" + _description + ") ";

        //     }
        //     return _displayList;
        // }
        // public override string RecordEvent(string name, string description, string goalPoints, string done = ". [ ] ",string repetitionsGoal = "", string bonusPoints= "", string  repetitionsMade = "")
        // {
        //     {
        //         _name = name;
        //         _description = description;
        //         _goalPoints = Convert.ToInt16(goalPoints);
        //         _done = done;
        //         _displayList = _done + _name + " (" + _description + ") ";

        //     }
        //     return _displayList;
        // }
        // public override string ForFileRecording()
        // {
        //     _ Activity = "SwimmingGoal:" + _name + "," + _description + "," + _goalPoints + "," + _try;
        //     return _ Activity;
        // }
        // public override int ListPoints()
        // {
        //     return _goalPoints;
        // }

        // public override string IsComplete(int x)
        // {

        //     if (x == 0)
        //     {
        //         return "False";
        //     }
        //     else
        //     {
        //         return "True";
        //     }
        // }
    }
}

