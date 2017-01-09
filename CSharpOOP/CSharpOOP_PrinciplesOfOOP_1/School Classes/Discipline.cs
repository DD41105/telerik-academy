using System;

namespace School_Classes
{
    class Discipline : ICommentable
    {
        private string disciplineName;
        private int numOfLectures;
        private int numOfExercises;
        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public string DisciplineName
        {
            get { return disciplineName; }
            set { disciplineName = value; }
        }

        public int NumOfLectures
        {
            get { return numOfLectures; }
            set { numOfLectures = value; }
        }

        public int NumOfExercises
        {
            get { return numOfExercises; }
            set { numOfExercises = value; }
        }

        public Discipline(string discName, int numOfLect, int numOfEx, string comment)
        {
            this.DisciplineName = discName;
            this.NumOfLectures = numOfLect;
            this.NumOfExercises = numOfEx;
            this.Comment = comment;
        }
    }
}