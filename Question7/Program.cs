using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program, which reads from the console two integer numbers N
            and K(K < N) and array of N integers.Find those K consecutive
            elements in the array, which have maximal sum.*/

            /*  Console.Write("Enter N:");
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
              }*/
            int[] array = { -3,7,-2,9,-1,5,-4,3,-3 };
            int K = 5;
            int count = 1, sum = 0, maxSum = 0, lastIndex = 0, startIndex = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                sum += array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    count++;
                    sum += array[j];
                    if (count == K)
                    {
                        if (sum >= maxSum)
                        {
                            maxSum = sum;
                            lastIndex = j;
                            startIndex = i;
                        }
                    }
                }
                count = 1;
                sum = 0;
            }
            Console.Write($"The maximal sum of {K} elements of the array is ");
            for (int a = startIndex; a <= lastIndex; a++)
            {
                Console.Write($"{array[a]}, ");
            }
            
        }
    }
}
