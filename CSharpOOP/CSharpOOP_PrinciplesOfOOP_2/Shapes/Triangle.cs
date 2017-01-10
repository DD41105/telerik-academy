using System;

namespace Shapes
{
    class Triangle : Shape
    {
        // constructor
        public Triangle(double width, double height)
            : base (width, height)
        {
        }

        // implement the abstract method from the Shape class
        public override void CalculateSurface()
        {
            double surface = (this.Height * this.Width / 2);
            Console.WriteLine(surface);
        }
    }
}