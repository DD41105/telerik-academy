using System;
using System.Collections.Generic;

namespace CSharpOOP_DefiningClasses_Part2
{
    public static class Path
    {
        private static List<Point3D> allPoints;

        static void SavePoint()
        {
            allPoints = new List<Point3D>();
        }

        static void Save(Point3D point)
        {
            allPoints.Add(point);
        }

        static List<Point3D> ReturnPoints()
        {
            return allPoints;
        }
    }
}