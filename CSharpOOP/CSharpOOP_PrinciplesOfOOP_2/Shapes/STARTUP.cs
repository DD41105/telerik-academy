using System;

namespace Shapes
{
    class STARTUP
    {
        static void Main()
        {
            // create an array of shapes to test the program
            Shape[] shapesArray = {
                                      new Triangle(5, 6),
                                      new Rectangle(7, 10),
                                      new Square(4),
                                      new Triangle(2.50, 3),
                                      new Square(4.40)
                                  };

            // calculate and print to the console
            Console.WriteLine("=== Calculated Areas ===");
            Console.WriteLine();
            foreach (var shape in shapesArray)
            {
                Console.Write("{0} area: ", shape.GetType().Name);
                shape.CalculateSurface();
            }
        }
    }
}