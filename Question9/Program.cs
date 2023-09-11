using System;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program, which finds a subsequence of numbers with
            maximal sum.E.g.: { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  11*/

            int sum = 0, currentCount = 1, bestSum = 0, startIndex = 0, save = 0, lastIndex = 0; ;
            // int[] array = { 2, 3, 9, -4, 9, -7, 1, 6, 7,};
            //int[] array = { -3, 7, -2, 9, -1, 5, -4, 3, -3 };
            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            for (int i = 0; i < array.Length; i++)
            {
                sum = array[i];
                for (int j = i + 1; j <= array.Length - 1; j++)
                {
                    sum += array[j];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        lastIndex = i;
                        save = j;
                        currentCount++;
                    }
                }
                currentCount = 1;
            }
            Console.WriteLine(bestSum);
            startIndex = (save - currentCount) + 1;
            for (int j = startIndex; j <= currentCount; j++)
            {
                Console.Write($"{array[j]},  ");
            }
        }
    }
}
