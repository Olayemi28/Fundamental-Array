using System;

namespace Question_24
{
    class Program
    {
        static void Main(string[] args)
        {
            string small = "a";
            string capital = "A";
            Console.Write(small.Equals(capital));

            /*Write a program, which reads an integer number N from the console and
            prints all combinations of K elements of numbers in range[1 … N].
            Example:N = 5, K = 2  { 1, 2}, { 1, 3}, { 1, 4}, { 1, 5}, { 2, 3}, { 2, 4}, 
            { 2, 5}, { 3, 4}, { 3, 5}, { 4, 5}.*/

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
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
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
