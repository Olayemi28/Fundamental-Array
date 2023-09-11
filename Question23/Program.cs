using System;

namespace Question_23
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program, which reads the integer numbers N and K from the
            console and prints all variations of K elements of the numbers in the
            interval[1…N]. Example: N = 3, K = 2  { 1, 1}, { 1, 2}, { 1, 3}, { 2, 1}, 
            { 2, 2}, { 2, 3}, { 3, 1}, { 3, 2}, { 3, 3}.*/

            /*Console.Write("Enter a number:");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter another number:");
            int K = int.Parse(Console.ReadLine());
            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= K; j++)
                {
                    Console.Write($"\t{i}, {j}");
                }
            }*/

            Console.Write("Enter N:");
            int N;
            while (!(int.TryParse(Console.ReadLine(), out N)))
            {
                Console.Write("Kindly enter a number:");
            }
            Console.Write("Enter K:");
            int K;
            while (!(int.TryParse(Console.ReadLine(), out K) && K < N))
            {
                Console.Write("Kindly enter a number:");
            }
            int[] array = new int[N];
            for (int a = 0; a < array.Length; a++)
            {
                Console.Write($"Enter array at index {a}: ");
                array[a] = int.Parse(Console.ReadLine());
            }
            int currentCount = 1;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    currentCount++;
                    if (currentCount == K)
                    {
                        Console.Write($"{{{array[i]}, {array[j]}}}  ");
                    }
                    currentCount = 1;
                }

            }
        }
    }
}
