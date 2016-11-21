using System;
using System.Collections.Generic;
using System.Numerics;

class OneSystemToAnyOther
{
    static void Main()
    {
        int startBase = int.Parse(Console.ReadLine());
        string number = Console.ReadLine();
        int finalBase = int.Parse(Console.ReadLine());

        BigInteger decNumber = ToDecimalSystem(startBase, number);
        List<string> decToAnotherSystem = DecToAnotherNumeralSystem(decNumber, finalBase);

        foreach (var item in decToAnotherSystem)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }

    // Decimal to any other

    static List<string> DecToAnotherNumeralSystem(BigInteger decNumber, int finalBase)
    {
        List<string> anySystem = new List<string>();
        BigInteger remainder = 0;
        while (decNumber > 0)
        {
            if (decNumber % finalBase == 0)
            {
                anySystem.Add("0");
            }
            if (decNumber % finalBase != 0)
            {
                remainder = decNumber % finalBase;

                switch (remainder.ToString())
                {
                    case "10":
                        anySystem.Add("A");
                        break;
                    case "11":
                        anySystem.Add("B");
                        break;
                    case "12":
                        anySystem.Add("C");
                        break;
                    case "13":
                        anySystem.Add("D");
                        break;
                    case "14":
                        anySystem.Add("E");
                        break;
                    case "15":
                        anySystem.Add("F");
                        break;
                    default:
                        anySystem.Add(remainder.ToString());
                        break;
                }
            }
            decNumber /= finalBase;
        }
        anySystem.Reverse();
        return anySystem;
    }

    // To Decimal

    static BigInteger ToDecimalSystem(int startBase, string number)
    {
        char[] someBaseArr = number.ToCharArray();
        Array.Reverse(someBaseArr);
        BigInteger decNumber = 0;

        for (int i = 0; i < someBaseArr.Length; i++)
        {
            switch (someBaseArr[i])
            {
                case 'A':
                    decNumber += 10 * BigInteger.Pow(startBase, i);
                    break;
                case 'B':
                    decNumber += 11 * BigInteger.Pow(startBase, i);
                    break;
                case 'C':
                    decNumber += 12 * BigInteger.Pow(startBase, i);
                    break;
                case 'D':
                    decNumber += 13 * BigInteger.Pow(startBase, i);
                    break;
                case 'E':
                    decNumber += 14 * BigInteger.Pow(startBase, i);
                    break;
                case 'F':
                    decNumber += 15 * BigInteger.Pow(startBase, i);
                    break;
                default:
                    decNumber += BigInteger.Parse(someBaseArr[i].ToString()) * BigInteger.Pow(startBase, i);
                    break;
            }
        }
        return decNumber;
    }
}