using System;

namespace CSharpOOP_DefiningClasses_Part2
{
    static class CalculateDistance
    {
        public static double CalculateDist(Point3D firstPoint, Point3D secondPoint)
        {
            double dist = Math.Pow((secondPoint.x - firstPoint.y), 2) +
                Math.Pow((secondPoint.y - firstPoint.y), 2) +
                Math.Pow((secondPoint.z - firstPoint.z), 2);
            double result = Math.Sqrt(dist);

            return result;
        }
    }
}