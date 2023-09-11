using System;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sorting an array means to arrange its elements in an increasing(or
            decreasing) order.Write a program, which sorts an array using the
            algorithm "selection sort".*/

            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            //int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            //int[] array = { 7, 1, 9, 5, 2, 6, 8, 3, 4, 0 };
            //int[] array = { 73, 57, 49, 99, 133, 20, 1 };
            int[] array = { 40, 10, 20, 30, 50 };
            for (int i = 0; i < array.Length; i++)
            {
                int smallestValue = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[smallestValue])
                    {
                        smallestValue = j;
                    }
                }
                int saveCurrent = array[smallestValue];
                array[smallestValue] = array[i];
                array[i] = saveCurrent;
                Console.Write($"{saveCurrent}, ");
            }
            watch.Stop();
            Console.Write($"Execution time:{watch.ElapsedMilliseconds}ms");
        }
    }
}
