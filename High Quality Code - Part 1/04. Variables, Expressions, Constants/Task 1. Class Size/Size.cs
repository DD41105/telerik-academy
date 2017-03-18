using System;

namespace Task1._Class_Size
{
    public class Size
    {
        public double Width, Height;

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public static Size GetRotatedSize(Size s, double angle)
        {
            return new Size(Math.Abs(Math.Cos(angle)) * s.Width + Math.Abs(Math.Sin(angle)) * s.Height,
                            Math.Abs(Math.Sin(angle)) * s.Width + Math.Abs(Math.Cos(angle)) * s.Height);
        }
    }
}