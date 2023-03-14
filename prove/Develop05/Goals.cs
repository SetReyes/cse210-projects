using System;

namespace goals_book
{
    public abstract class Goals

    {
        // variables
        protected int _selection;
        protected string _goalType;
        protected string _displayList;
        protected string _name;
        protected string _description;
        protected int _goalPoints;
        protected double _bonusPoints;
        protected int _repetitionsGoal;
        protected int _repetitionsBonus;
        protected bool _try;
        protected string _goals;
        protected string _done;
        
        public int _totalPoints;
        public string[] _goalInformation = {
    "What is the name of your goal? ",
    "What is a short description of it? ",
    "What is the amount of points associated with this goal? ",
    "How many times does this goal need to be accomplished for a bonus? ", "What is the bonus for accomplishing it that many times? " };

        // A constructor
        public Goals()
        {
        }
        // Behaviours or member functions
        public int ShowMenu()
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create New Goal ");
            Console.WriteLine(" 2. List Goals ");
            Console.WriteLine(" 3. Save Goals ");
            Console.WriteLine(" 4. Load Goals ");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            _selection = Convert.ToInt16(Console.ReadLine());
            return _selection;
        }
        public string GoalMenu()
        {
            Console.WriteLine("The types of Goals are: ");
            Console.WriteLine(" 1. Simple Goal ");
            Console.WriteLine(" 2. Eternal Goal ");
            Console.WriteLine(" 3. Checklist Goal ");
            Console.Write("Which type of goal would you like to create? ");
            return _goalType = Console.ReadLine();
        }
        public abstract string RecordGoal();
        public abstract string ForFileRecording();
        public abstract int ListPoints();
        public abstract string RecordEvent(string name, string description, string goalPoints, string done = ". [ ] ", string repetitionsGoal = "", string bonusPoints = "", string repetitionsMade = "");
        public abstract string IsComplete(int x); // por usar

        public int GetSelection()
        {
            return _selection;
        }
        public string GetGoalType()
        {
            return _goalType;
        }
        public string GetGoals()
        {
            return _displayList;
        }
        public string GetSaveGoal()
        {
            return _goals;
        }
        public int GetPointsPer()
        {
            return _goalPoints;
        }

    }

}

