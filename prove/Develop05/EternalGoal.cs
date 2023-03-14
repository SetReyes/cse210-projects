using System;

namespace goals_book
{
    public class Eternal : Goals

    {
        // A constructor
        public Eternal() : base()
        {

        }
        // Behaviours or member functions
        public override string RecordGoal()
        {
            // if (goal == "2")
            {
                _done = ". [ ] ";
                Console.Write($"{_goalInformation[0]}");
                _name = Console.ReadLine();
                Console.Write($"{_goalInformation[1]}");
                _description = Console.ReadLine();
                Console.Write($"{_goalInformation[2]}");
                _goalPoints = Convert.ToInt16(Console.ReadLine());
                _displayList = _done + _name + " (" + _description + ") ";

            }

            return _displayList;
        }
        public override string RecordEvent(string name, string description, string goalPoints, string done = ". [ ] ", string repetitionsGoal = "", string bonusPoints = "", string repetitionsMade = "")
        {
            {
                _name = name;
                _description = description;
                _goalPoints = Convert.ToInt16(goalPoints);
                _done = done;
                _displayList = _done + _name + " (" + _description + ") ";
            }
            return _displayList;
        }
        public override string ForFileRecording()
        {
            _goals = "EternalGoal:" + _name + "," + _description + "," + _goalPoints;
            return _goals;
        }
        public override int ListPoints()
        {
            return _goalPoints;
        }
        public override string IsComplete(int x)
        {
            if (x == 0)
            {
                return "False";
            }
            else
            {
                return "False";
            }
        }
    }
}

