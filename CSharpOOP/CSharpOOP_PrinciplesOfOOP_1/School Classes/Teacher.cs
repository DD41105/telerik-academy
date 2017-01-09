using System;

namespace School_Classes
{
    class Teacher : Person, ICommentable
    {
        private Discipline teachingDiscipline;
        private string comment;

        public Discipline TeachingDiscipline
        {
            get { return teachingDiscipline; }
            set { teachingDiscipline = value; }
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        // constructors
        public Teacher(string name, Discipline discipline)
            : base(name)
        {
            this.TeachingDiscipline = discipline;
        }

        public Teacher(string name, string comment)
            : base(name)
        {
            this.Comment = comment;
        }

        public Teacher(string name)
            : base(name)
        {
            this.Name = name;
        }
    }
}