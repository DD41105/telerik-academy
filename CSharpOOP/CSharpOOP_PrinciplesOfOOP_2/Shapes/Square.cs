using System;

namespace Shapes
{
    class Square : Shape
    {
        // simple constructor that makes the square's sides equal
        public Square(double side)
            : base (side, side)
        {
        }

        // implement the abstract method from the Shape class
        public override void CalculateSurface()
        {
            double surface = (this.Width * this.Width);
            Console.WriteLine(surface);
        }
    }
}