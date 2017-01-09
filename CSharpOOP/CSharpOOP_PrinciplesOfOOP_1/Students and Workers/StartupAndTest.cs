using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_and_Workers
{
    class StartupAndTest
    {
        static void Main()
        {
            // initialize a list of 10 students
            List<Student> students = new List<Student>();
            students.Add(new Student("Stefan", "Marinov", 5.64));
            students.Add(new Student("Maria", "Koleva", 4.59));
            students.Add(new Student("Alexander", "Tonev", 3.21));
            students.Add(new Student("Ioana", "Dragomirova", 5.77));
            students.Add(new Student("Trayan", "Stoyanov", 4.45));
            students.Add(new Student("Gergana", "Ivanova", 3.90));
            students.Add(new Student("Vasil", "Velchev", 5.10));
            students.Add(new Student("Silvia", "Stoeva", 5.25));
            students.Add(new Student("Petur", "Petkov", 3.50));
            students.Add(new Student("Georgi", "Georgiev", 5.80));

            // print the unsorted list
            Console.WriteLine("=== UNSORTED LIST OF STUDENTS ===");
            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Grade);
            }
            Console.WriteLine();

            // sort them by grade in ascending order using LINQ
            List<Student> sortedStudents = students.OrderBy(o => o.Grade).ToList();

            // print the sorted list on the console to test
            Console.WriteLine("=== SORTED LIST OF STUDENTS ===");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Grade);
            }
            Console.WriteLine();

            // initialize a list of 10 workers
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Petur", "Alipiev", 320m, 9m));
            workers.Add(new Worker("Georgi", "Kaloyanov", 250m, 8.5m));
            workers.Add(new Worker("Radina", "Tsoneva", 245.50m, 7.5m));
            workers.Add(new Worker("Krasimira", "Pencheva", 262m, 9m));
            workers.Add(new Worker("Anton", "Demirev", 260m, 9.5m));
            workers.Add(new Worker("Stefka", "Stoykova", 355m, 7m));
            workers.Add(new Worker("Martin", "Minchev", 225m, 8m));
            workers.Add(new Worker("Anelia", "Boteva", 280.50m, 5m));
            workers.Add(new Worker("Todor", "Boyanov", 210m, 8m));
            workers.Add(new Worker("Boyko", "Georgiev", 190m, 9m));

            // print the unsorted list of workers
            Console.WriteLine("=== UNSORTED LIST OF WORKERS ===");
            foreach (var worker in workers)
            {
                Console.WriteLine(worker.FirstName + " " + worker.LastName + " " + worker.MoneyPerHour());
            }
            Console.WriteLine();

            // sort workers by MoneyPerHour in descending order
            List<Worker> orderedWorkers = workers.OrderByDescending(x => x.MoneyPerHour()).ToList();

            // print the sorted list of workers
            Console.WriteLine("=== SORTED LIST OF WORKERS ===");
            foreach (var worker in orderedWorkers)
            {
                Console.WriteLine(worker.FirstName + " " + worker.LastName + " " + worker.MoneyPerHour());
            }
            Console.WriteLine();

            // merge the lists and sort them by first and last name
            List<Human> mergedList = MergeTwoLists(sortedStudents, orderedWorkers);
            List<Human> orderedHumans = OrderHumansByFirstAndLastName(mergedList);
            // print the result
            Console.WriteLine("=== MERGED LIST OF STUDENTS AND WORKERS ===");
            foreach (var human in orderedHumans)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }
        }

        // a few extra methods
        private static List<Human> MergeTwoLists(IEnumerable<Student> sortedStudents, IEnumerable<Worker> sortedWorkers)
        {
            List<Human> result = new List<Human>();

            result.AddRange(sortedStudents);
            result.AddRange(sortedWorkers);

            return result;
        }

        private static List<Human> OrderHumansByFirstAndLastName(IEnumerable<Human> mergedList)
        {
            var result = mergedList.OrderBy(x => x.FirstName)
                                   .ThenBy(x => x.LastName)
                                   .ToList();

            return result;
        }
    }
}