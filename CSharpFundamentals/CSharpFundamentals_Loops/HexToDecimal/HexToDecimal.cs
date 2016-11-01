using System;
using System.Numerics;
using System.Text.RegularExpressions;

class HexToDecimal
{
    static void Main()
    {
        string hex = Console.ReadLine();
        string[] hexArray = Regex.Split(hex, "");
        long counter = 0;
        BigInteger sum = 0;

        for (int i = hexArray.Length - 2; i > 0; i--)
        {
            switch (hexArray[i])
            {
                case "A":
                    sum = sum + 10 * (long)Math.Pow(16, counter);
                    break;
                case "B":
                    sum = sum + 11 * (long)Math.Pow(16, counter);
                    break;
                case "C":
                    sum = sum + 12 * (long)Math.Pow(16, counter);
                    break;
                case "D":
                    sum = sum + 13 * (long)Math.Pow(16, counter);
                    break;
                case "E":
                    sum = sum + 14 * (long)Math.Pow(16, counter);
                    break;
                case "F":
                    sum = sum + 15 * (long)Math.Pow(16, counter);
                    break;
                default:
                    sum = sum + int.Parse(hexArray[i]) * (long)Math.Pow(16, counter);
                    break;
            }
            counter++;
        }
        Console.WriteLine(sum);
    }
}