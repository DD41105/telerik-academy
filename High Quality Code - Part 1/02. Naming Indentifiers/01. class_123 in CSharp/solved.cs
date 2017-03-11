using System;

class class_123
{
    const int MAX_COUNT = 6;

    class InClass_class_123
    {
        void boolToString(bool input)
        {
            string result = input.ToString();
            Console.WriteLine(result);
        }
    }

    public static void Main()
    {
        class_123.InClass_class_123 instance = new class_123.InClass_class_123();
        instance.boolToString(true);
    }
}
