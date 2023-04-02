using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace Activity_book
{
    public abstract class Activity

    {
        // variables
        protected string _date;
        protected double _timeLength;
        protected double _distance;
        protected double _speed;// km/hr
        protected double _pace;// min/km
        protected int _selection;
        protected string _activityRecord;
        protected string _displayList;

        // A constructor
        public Activity()
        {
        }
        // Behaviours or member functions
        public abstract string RecordActivity(string type = "");
        public abstract double GetDistance();
        public abstract double GetSpeed() ;
        public abstract double GetPace();
        public string GetSummary()
        { return _displayList; }
    }

}

