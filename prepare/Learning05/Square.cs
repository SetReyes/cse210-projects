using System;

namespace shapes_areas
{

    public class Square : Shape

    {
        // variables
        private double _side;

        // A constructor
        public Square(string color, double side) : base(color)
        {
            _side = side;
        }
        // Behaviours or member functions
        public override double GetArea()
        {
            double areaSquare = _side * _side;
            return areaSquare;
        }

    }
}