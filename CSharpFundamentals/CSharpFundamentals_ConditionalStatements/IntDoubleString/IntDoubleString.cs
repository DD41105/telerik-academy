using System;

namespace IntDoubleString
{
    class IntDoubleString
    {
        static void Main()
        {
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "integer":
                    int integerNum = int.Parse(Console.ReadLine());
                    Console.WriteLine(integerNum = integerNum + 1);
                    break;
                case "real":
                    double doubleNum = double.Parse(Console.ReadLine());
                    doubleNum = doubleNum + 1;
                    Console.WriteLine("{0:F2}", doubleNum);
                    break;
                case "text":
                    string name = Console.ReadLine();
                    Console.WriteLine(name + "*");
                    break;
                default:
                    break;
            }
        }
    }
}