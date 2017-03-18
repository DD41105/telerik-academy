using System;

namespace Task_2.Method_PrintStatistics
{
    class PrintStatisticsClass
    {
        public void PrintStatistics(double[] arrayToCheck, int count)
        {
            // initializa the max as being equal to the first element of the array, then check if any of the others is bigger
            double max = arrayToCheck[0];
            for (int i = 0; i < count; i++)
            {
                if (arrayToCheck[i] > max)
                {
                    max = arrayToCheck[i];
                }
            }
            Console.WriteLine("Max: {0}", max);

            // a way to get the minimum - initialize the minimum as being equal to the first element of the array; then check if any of the others is smaller
            double min = arrayToCheck[0];
            for (int i = 0; i < count; i++)
            {
                if (arrayToCheck[i] < min)
                {
                    min = arrayToCheck[i];
                }
            }
            Console.WriteLine("Min: {0}", min);

            // a way to get the sum
            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += arrayToCheck[i];
            }
            Console.WriteLine("Sum: {0}", sum);

            // a way to get the average (tmp / count)
            double average = sum / count;
            Console.WriteLine("Average: {0}", average);
        }
    }
}
