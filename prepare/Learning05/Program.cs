using System;
namespace shapes_areas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Rectangle testRectangle = new Rectangle("Green", 5, 3);
            shapes.Add(testRectangle);
            Square testSquare = new Square("Blue", 10.45452);
            shapes.Add(testSquare);
            Circle testCircle = new Circle("Cian", 1);
            shapes.Add(testCircle);

            foreach (Shape item in shapes)
            {
                // Passing color from parent class
                string color = item.GetColor();

                // Using abstract to call GetArea from parent class
                double area = item.GetArea();

                Console.WriteLine($"The area of the {color} geometric shape is {Math.Round(area, 2)} m2.");

            }
        }
    }
}