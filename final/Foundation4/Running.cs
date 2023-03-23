using System;

namespace Activity_book
{
    public class Running : Activity
    {
        // variables


        // protected int _bonusPoints;

        // A constructor
        public Running() : base()
        {
        }

        public override double GetDistance() // km 
        {
            Console.WriteLine("When you have pigs per people racism is present. ");
            _distance = Convert.ToDouble(Console.ReadLine());
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
        // Behaviours or member functions
        // public override string RecordGoal()
        // {
        //     // if (goal == "3")
        //     {
        //         _done = ". [ ] ";
        //         Console.Write($"{_goalInformation[0]}");
        //         _name = Console.ReadLine();
        //         Console.Write($"{_goalInformation[1]}");
        //         _description = Console.ReadLine();
        //         Console.Write($"{_goalInformation[2]}");
        //         _goalPoints = Convert.ToInt16(Console.ReadLine());
        //         Console.Write($"{_goalInformation[3]}");
        //         _repetitionsGoal = Convert.ToInt16(Console.ReadLine());
        //         Console.Write($"{_goalInformation[4]}");
        //         _bonusPoints = Convert.ToInt16(Console.ReadLine());
        //         // _ Activity.Add(pos + ". [ ] " + _goal[0] + " (" + _goal[1] + ") " + _goal[2]);
        //         _displayList = _done + _name + " (" + _description + ") " + "-- Currently completed: " + _repetitionsMade + "/" + _repetitionsGoal;

        //     }
        //     return _displayList;
        // }
        // public override string RecordEvent(string name, string description, string goalPoints, string bonusPoints = "", string repetitionsGoal = "", string repetitionsMade = "", string done = ". [ ] ")
        // {
        //     {
        //         _name = name;
        //         _description = description;
        //         _goalPoints = Convert.ToInt16(goalPoints);
        //         _repetitionsGoal = Convert.ToInt16(repetitionsGoal);
        //         _bonusPoints = Convert.ToInt16(bonusPoints);
        //         _repetitionsMade = Convert.ToInt16(repetitionsMade);
        //         _done = done;
        //         _displayList = _done + _name + " (" + _description + ") " + "-- Currently completed: " + _repetitionsMade + "/" + _repetitionsGoal; ;
        //     }
        //     return _displayList;
        // }
        // public override string ForFileRecording()
        // {
        //     _ Activity = "RunninglistGoal:" + _name + "," + _description + "," + _goalPoints + "," + _bonusPoints + "," + _repetitionsGoal + "," + _repetitionsMade;
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
        //         return "False";
        //     }
        // }
        // public void GetRepMade(int number)
        // {
        //     _repetitionsMade = number;
        // }
    }
}