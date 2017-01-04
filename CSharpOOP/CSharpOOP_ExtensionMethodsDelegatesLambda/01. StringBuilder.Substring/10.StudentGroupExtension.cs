using StudentGroups;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGroupsExtensions
{
    class StudentGroupsExtensions
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan", "Ivanchev", 42412, "+3598815124", "pencho@gmail.com", 3),
                new Student("Dimitar", "Dimitriev", 42413, "+3598815124", "pencho@gmail.com", 2),
                new Student("Anna", "Pencheva", 42414, "+35981244", "pencho@gmail.com", 1),
                new Student("Tsvetelina", "Ivanova", 42415, "+3598815124", "pencho@gmail.com", 4),
                new Student("Georgi", "Penchev", 42416, "+359881511251", "pencho@gmail.com", 2),
                new Student("Ioana", "Penova", 42417, "+359881512131", "pencho@gmail.com", 2),
                new Student("Alexander", "Genov", 42418, "+3598815124", "pencho@gmail.com", 3),
                new Student("Trifon", "Penchev", 42419, "+3598815124", "pencho@gmail.com", 2),
                new Student("Hristo", "Todorov", 424110, "+3598815124", "pencho@gmail.com", 2),
                new Student("Maria", "Pencheva", 424111, "+3598815124", "pencho@gmail.com", 3),
            };

            var sortedStudents = students.Where(s => s.GroupNumber == (byte)2)
                .OrderBy(s => s.FirstName);

            foreach (Student student in sortedStudents)
                Console.WriteLine(student);
        }
    }
}