namespace Shapes
{
    public abstract class Shape
    {
        // fields and properties
        private double width;
        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }


        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        // constructor
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        // the abstract method that we have to create here as part of the exercise
        public abstract void CalculateSurface();
    }
}