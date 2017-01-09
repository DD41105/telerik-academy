using System;

namespace Animal_Hierarchy
{
    class Frog : Animal
    {
        // call the Animal constructor
        public Frog(string name, int age, bool isMale)
            : base(name, age, isMale)
        {

        }

        // override the virtual method ProduceSound that is already defined in the Animal class
        public override void ProduceSound()
        {
            Console.WriteLine("The frog croaks!");
        }

        public void CatchAFly()
        {
            Console.WriteLine("The frog suddenly catches a fly with its long tongue!");
        }
    }
}