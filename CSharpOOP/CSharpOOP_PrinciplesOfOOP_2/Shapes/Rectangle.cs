using System;

namespace Shapes
{
    class Rectangle : Shape
    {
        // constructor
        public Rectangle(double width, double height)
            : base (width, height)
        {
        }

        // implement the abstract method from the Shape class
        public override void CalculateSurface()
        {
            double surface = (this.Width * this.Height);
            Console.WriteLine(surface);
        }
    }
}