using System;
namespace shapes_areas
{

    public class Rectangle : Shape

    {
        // member variables
        private double _width;
        private double _length;

        // A constructor
        public Rectangle(string color, double length, double width) : base(color)
        {
            _width = width;
            _length = length;
        }
        // Behaviours or member functions
        public override double GetArea()
        {
            double areaRectangle = _length * _width;
            return areaRectangle;
        }

    }
}



