using System;

namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program to find a sequence of neighbor numbers in an array,
            which has a sum of certain number S.Example: { 4, 3, 1, 4, 2, 5, 8},
            S = 11  { 4, 2, 5}.*/

            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            Console.Write("Enter N:");
            int N;
            while (!(int.TryParse(Console.ReadLine(), out N)))
            {
                Console.Write("Kindly enter a number:");
            }
            Console.Write("Enter Sum:");
            int sum;
            while (!(int.TryParse(Console.ReadLine(), out sum)))
            {
                Console.Write("Kindly enter a number:");
            }
            int[] array = new int[N];
            for (int a = 0; a < array.Length; a++)
            {
                Console.Write($"Enter array at index {a}: ");
                array[a] = int.Parse(Console.ReadLine());
            }
            int maxCount = 0, lastIndex = 0, addition = 0, currentCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                addition += array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    currentCount++;
                    addition += array[j];
                    if (addition == sum)
                    {
                        lastIndex = j;
                        maxCount = currentCount;
                        break;
                    }
                }
                currentCount = 0;
                addition = 0;
            }
            int firstIndex = 0;
            if (maxCount > lastIndex)
            {
                firstIndex = (lastIndex - maxCount) + 1;
            }
            if (maxCount <= lastIndex)
            {
                firstIndex = (lastIndex - maxCount);
            }
            for (int i = firstIndex; i <= lastIndex; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            watch.Stop();
            Console.Write($"Execution time:{watch.ElapsedMilliseconds}ms");
        }
    }
}
