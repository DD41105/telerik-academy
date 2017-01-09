using System;
using System.Linq;
using System.Collections.Generic;

namespace Animal_Hierarchy
{
    class StartupAndTest
    {
        static void Main()
        {
            // create arrays of different kinds of animals
            Dog[] dogsArray =
            {
                new Dog("Sharo", 8, true),
                new Dog("Lisa", 4, false),
                new Dog("Lucky", 2, true),
                new Dog("Balkan", 7, true)
            };

            Frog[] frogsArray =
            {
                new Frog("Goshko", 2, true),
                new Frog("Penka", 1, false),
                new Frog("Stamatka", 2, false)
            };

            Cat[] catsArray =
            {
                new Kitten("Totka", 1),
                new Tomcat("Pesho", 3),
                new Tomcat("Tom", 5),
                new Kitten("Siika", 2)
            };

            // create a list of all animals
            List<Animal> allAnimals = new List<Animal>();
            allAnimals.AddRange(dogsArray);
            allAnimals.AddRange(catsArray);
            allAnimals.AddRange(frogsArray);

            // calculate and print the average age
            Console.WriteLine("The average age of the dogs in the array is: {0} years.", CalculateAverageYears(dogsArray));
            Console.WriteLine("The average age of the cats in the array is: {0} years.", CalculateAverageYears(catsArray));
            Console.WriteLine("The average age of the frogs in the array is: {0} years.", CalculateAverageYears(frogsArray));

            // test the ProduceSound methods in the different classes
            Console.WriteLine();
            Console.WriteLine("Here is what the animals have to say about this homework:");
            dogsArray[0].ProduceSound();
            catsArray[0].ProduceSound();
            catsArray[1].ProduceSound();
            frogsArray[0].ProduceSound();
        }

        // method to calculate the average age
        private static double CalculateAverageYears(Animal[] collection)
        {
            double averageAge = collection.Average(x => x.Age);

            return Math.Round(averageAge, 2);
        }
    }
}