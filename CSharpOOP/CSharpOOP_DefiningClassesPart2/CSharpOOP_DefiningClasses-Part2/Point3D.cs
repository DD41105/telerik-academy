using System;

namespace CSharpOOP_DefiningClasses_Part2
{
    public struct Point3D
    {
        public double x;
        public double y;
        public double z;

        public static readonly Point3D pointO = new Point3D(0, 0, 0);

        public Point3D(double X, double Y, double Z)
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
        }

        public override string ToString()
        {
            return $"Current coordinates: ({x}, {y}, {z})";
        }
    }
}