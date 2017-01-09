namespace Students_and_Workers
{
    class Student : Human
    {
        // fields and properties
        private double grade;

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        // constructor that also calls the base class' constructor
        public Student(string firstName, string lastName, double grade)
            : base(firstName, lastName)
        {
            this.grade = grade;
        }
    }
}