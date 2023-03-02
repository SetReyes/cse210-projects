using System;
namespace shapes_areas
{

    public class Circle : Shape

    {
        // variables
        private double _radius;

        // A constructor
        public Circle(string color, double radius) : base(color)
        {
            _radius = radius;
        }
        // Behaviours or member functions
        public override double GetArea()
        {
            double areaCircle = (Math.Pow(_radius, 2) * Math.PI);
            return areaCircle;
        }

    }
}