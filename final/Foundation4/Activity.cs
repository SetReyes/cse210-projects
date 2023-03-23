using System;

namespace Activity_book
{
    public abstract class Activity

    {
        // variables
        protected int _date;
        protected double _timeLength;
        protected double _distance;
        protected double _speed;// km/hr
        protected double _pace;// min/km

        //     protected string _name;
        //     protected string _description;
        //     protected int _goalPoints;
        //     protected double _bonusPoints;
        //     protected int _repetitionsGoal;
        //     protected int _repetitionsBonus;
        //     protected bool _try;
        //     protected string _ Activity;
        //     protected string _done;
        //     public int _totalPoints;
        //     public string[] _goalInformation = {
        // "What is the name of your goal? ",
        // "What is a short description of it? ",
        // "What is the amount of points associated with this goal? ",
        // "How many times does this goal need to be accomplished for a bonus? ", "What is the bonus for accomplishing it that many times? " };

        // A constructor
        public Activity()
        {
        }
        // Behaviours or member functions
        public int ShowMenu()
        {
            // Console.WriteLine("Menu Options: ");
            // Console.WriteLine(" 1. Create New Goal ");
            // Console.WriteLine(" 2. List  Activity ");
            // Console.WriteLine(" 3. Save  Activity ");
            // Console.WriteLine(" 4. Load  Activity ");
            // Console.WriteLine(" 5. Record Event");
            // Console.WriteLine(" 6. Quit");
            // Console.Write("Select a choice from the menu: ");
            // _selection = Convert.ToInt16(Console.ReadLine());
            return 1;
        }
        // public string GoalMenu()
        // {
        //     Console.WriteLine("The types of  Activity are: ");
        //     Console.WriteLine(" 1. Simple Goal ");
        //     Console.WriteLine(" 2. Eternal Goal ");
        //     Console.WriteLine(" 3. Checklist Goal ");
        //     Console.Write("Which type of goal would you like to create? ");
        //     return _goalType = Console.ReadLine();
        // }
        public virtual double GetDistance() // km 
        { return 2.2; }
        public virtual double GetSpeed() // km/hr
        { return 2.2; }
        public virtual double GetPace() // km/min
        { return 2.2; }

        public string GetSummary() // overriden or not in the derived classes
        { return "a"; }

        // public abstract int ListPoints();
        // public abstract string RecordEvent(string name, string description, string goalPoints, string done = ". [ ] ", string repetitionsGoal = "", string bonusPoints = "", string repetitionsMade = "");
        // public abstract string IsComplete(int x); // por usar

        // public int GetSelection()
        // {
        //     return _selection;
        // }
        // public string GetGoalType()
        // {
        //     return _goalType;
        // }
        // public string Get Activity()
        // {
        //     return _displayList;
        // }
        // public string GetSaveGoal()
        // {
        //     return _ Activity;
        // }
        // public int GetPointsPer()
        // {
        //     return _goalPoints;
        // }
        
    }

}

