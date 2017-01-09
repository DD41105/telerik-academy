using System;

namespace Animal_Hierarchy
{
    class Tomcat : Cat
    {
        // call the base (Cat) constructor and set the gender of the tomcat to male always
        public Tomcat(string name, int age)
            : base(name, age, true)
        {

        }

        // override the virtual method ProduceSound that is already defined in the Animal class
        public override void ProduceSound()
        {
            Console.WriteLine("The tomcat is too lazy to even meow at you!");
        }
    }
}