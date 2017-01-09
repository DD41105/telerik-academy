using System;

namespace School_Classes
{
    class Student : Person, ICommentable
    {
        private int uniqueNumber;
        private string comment;

        public int UniqueNumber
        {
            get { return uniqueNumber; }
            set { uniqueNumber = value; }
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        // constructors
        public Student(string name, int classNumber)
            : base(name)
        {
            this.UniqueNumber = classNumber;
        }

        public Student(string name, int classNumber, string comment)
            : this(name, classNumber)
        {
            this.Comment = comment;
        }

        // override ToString method for testing purposes
        public override string ToString()
        {
            return string.Format("Student Name: {0}; Class Number: {1}; Comment: {2}", this.Name, this.UniqueNumber, this.Comment);
        }
    }
}