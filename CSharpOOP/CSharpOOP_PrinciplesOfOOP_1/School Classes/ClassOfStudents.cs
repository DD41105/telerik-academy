using System;
using System.Collections.Generic;
using System.Text;

namespace School_Classes
{
    class ClassOfStudents : ICommentable
    {
        private Teacher classTeacher;
        private string classIdentifier;
        private List<Student> listOfStudents;
        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }


        public string ClassIdentifier
        {
            get { return classIdentifier; }
            set { classIdentifier = value; }
        }

        public Teacher ClassTeacher
        {
            get { return classTeacher; }
            set { classTeacher = value; }
        }

        public List<Student> ListOfStudents
        {
            get { return listOfStudents; }
            set { listOfStudents = value; }
        }

        // a few constructors
        public ClassOfStudents(string classId)
        {
            this.classIdentifier = classId;
            this.listOfStudents = new List<Student>();
        }

        public ClassOfStudents(string classId, string comment)
            : this(classId)
        {
            this.Comment = comment;
        }

        // a few methods
        public void AddStudent(Student student)
        {
            this.listOfStudents.Add(student);
        }

        public void AddStudent(params Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                this.listOfStudents.Add(students[i]);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("Text identifier: {0}; Comment: {1}", this.ClassIdentifier, this.Comment));
            
            foreach (Student st in this.ListOfStudents)
            {
                result.AppendLine("          " + st.ToString());
            }

            return result.ToString();
        }
    }
}