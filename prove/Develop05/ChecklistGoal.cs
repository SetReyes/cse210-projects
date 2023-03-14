using System;

namespace goals_book
{
    public class Check : Goals
    {
        // variables
        // private int _pointsAward;
        private int _repetitionsMade = 0;
        // protected int _bonusPoints;

        // A constructor
        public Check() : base()
        {
        }
        // Behaviours or member functions
        public override string RecordGoal()
        {
            // if (goal == "3")
            {
                _done = ". [ ] ";
                Console.Write($"{_goalInformation[0]}");
                _name = Console.ReadLine();
                Console.Write($"{_goalInformation[1]}");
                _description = Console.ReadLine();
                Console.Write($"{_goalInformation[2]}");
                _goalPoints = Convert.ToInt16(Console.ReadLine());
                Console.Write($"{_goalInformation[3]}");
                _repetitionsGoal = Convert.ToInt16(Console.ReadLine());
                Console.Write($"{_goalInformation[4]}");
                _bonusPoints = Convert.ToInt16(Console.ReadLine());
                // _goals.Add(pos + ". [ ] " + _goal[0] + " (" + _goal[1] + ") " + _goal[2]);
                _displayList = _done + _name + " (" + _description + ") " + "-- Currently completed: " + _repetitionsMade + "/" + _repetitionsGoal;

            }
            return _displayList;
        }
        public override string RecordEvent(string name, string description, string goalPoints, string bonusPoints = "", string repetitionsGoal = "", string repetitionsMade = "", string done = ". [ ] ")
        {
            {
                _name = name;
                _description = description;
                _goalPoints = Convert.ToInt16(goalPoints);
                _repetitionsGoal = Convert.ToInt16(repetitionsGoal);
                _bonusPoints = Convert.ToInt16(bonusPoints);
                _repetitionsMade = Convert.ToInt16(repetitionsMade);
                _done = done;
                _displayList = _done + _name + " (" + _description + ") " + "-- Currently completed: " + _repetitionsMade + "/" + _repetitionsGoal; ;
            }
            return _displayList;
        }
        public override string ForFileRecording()
        {
            _goals = "ChecklistGoal:" + _name + "," + _description + "," + _goalPoints + "," + _bonusPoints + "," + _repetitionsGoal + "," + _repetitionsMade;
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
        public void GetRepMade(int number)
        {
            _repetitionsMade = number;
        }
    }
}