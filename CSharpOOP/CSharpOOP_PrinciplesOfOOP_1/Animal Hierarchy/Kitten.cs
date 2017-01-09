using System;

namespace Animal_Hierarchy
{
    class Kitten : Cat
    {
        // call the base (Cat) constructor and set the gender of the kitten to female always
        public Kitten(string name, int age) 
            : base(name, age, false)
        {

        }

        // override the virtual method ProduceSound that is already defined in the Animal class
        public override void ProduceSound()
        {
            Console.WriteLine("The kitten can barely meow!");
        }
    }
}