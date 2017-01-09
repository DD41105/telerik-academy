using System;

namespace School_Classes
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // constructor that will be used as a base
        protected Person(string name)
        {
            this.Name = name;
        }
    }
}