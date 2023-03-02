using System;

namespace shapes_areas
{
    public abstract class Shape

    {
        // variables
        protected string _color;

        // A constructor
        public Shape( string color)
        {
            _color = color;
        }
        // Behaviours or member functions
        public string GetColor()
        {
            return _color;
        }
        public void SetColor(string color)
        {
            _color = color;
        }
        public abstract double GetArea();
    }

}