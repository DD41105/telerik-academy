using System;

namespace Animal_Hierarchy
{
    class Dog : Animal
    {
        // call the Animal constructor
        public Dog(string name, int age, bool isMale)
            : base(name, age, isMale)
        {
            
        }

        // override the virtual method ProduceSound that is already defined in the Animal class
        public override void ProduceSound()
        {
            Console.WriteLine("The dog barks!");
        }

        public void WaveTail()
        {
            Console.WriteLine("The dog happily waves its tail and wants to play with you.");
        }
    }
}