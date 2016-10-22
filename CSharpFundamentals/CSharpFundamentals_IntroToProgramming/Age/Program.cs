using System;
using System.Globalization;

class Age
{
    static void Main()
    {
        string birthday = Console.ReadLine();
        DateTime bd = DateTime.ParseExact(birthday, "MM.dd.yyyy", CultureInfo.InvariantCulture);
        DateTime now = new DateTime(2016, 3, 3);
        int age;

        if (now.Month >= bd.Month)
        {
            age = now.Year - bd.Year;
        }
        else
            age = now.Year - bd.Year - 1;

        if (now.Day <= bd.Day && now.Month == bd.Month)
        {
            age--;
        }

        if (age < 0)
        {
            age++;
        }

        Console.WriteLine(age);
        Console.WriteLine(age + 10);
    }
}