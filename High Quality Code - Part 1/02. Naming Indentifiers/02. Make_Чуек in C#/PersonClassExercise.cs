using System;

class ProgramToTestThePersonClass
{
    enum Gender
    {
        Male,
        Female
    };

    class Person
    {
        public Gender Gender { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public void CreatePerson(int uniqueIdOfPerson)
    {
        Person samplePerson = new Person();
        samplePerson.Age = uniqueIdOfPerson;

        if (uniqueIdOfPerson % 2 == 0)
        {
            samplePerson.Name = "The Man";
            samplePerson.Gender = Gender.Male;
        }
        else
        {
            samplePerson.Name = "The Girl";
            samplePerson.Gender = Gender.Female;
        }
    }
}