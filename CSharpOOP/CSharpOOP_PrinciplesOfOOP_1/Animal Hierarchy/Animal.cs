using System;

namespace Animal_Hierarchy
{
    class Animal : ISound
    {
        // fields and properties
        private int age;
        private string name;
        private bool isMale;

        public bool IsMale
        {
            get { return isMale; }
            set { isMale = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // base constructor for the animals
        public Animal(string name, int age, bool isMale)
        {
            this.Name = name;
            this.Age = age;
            this.IsMale = isMale;
        }

        // methods
        public virtual void ProduceSound()
        {
            Console.WriteLine("Each animal must be able to produce a different sound.");
        }
    }
}