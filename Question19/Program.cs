using System;

namespace Question_19
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            for (int i = 2; i <= 10000000; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write($"{i}, ");
                }
            }
            stopWatch.Stop();
            Console.Write($"Execution time:{stopWatch.ElapsedMilliseconds}ms");
        }
    }
}
