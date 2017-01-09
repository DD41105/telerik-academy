using System;

namespace Animal_Hierarchy
{
    class Cat : Animal
    {
        // call the Animal constructor
        public Cat(string name, int age, bool isMale)
            : base(name, age, isMale)
        {

        }

        // override the virtual method ProduceSound that is already defined in the Animal class
        public override void ProduceSound()
        {
            Console.WriteLine("The cat meows!");
        }

        public void CatsAttitude()
        {
            Console.WriteLine("The cat looks at you as if you are nothing and goes back to sleep.");
        }
    }
}