using System;

namespace Question_21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program which by given N numbers, K and S, finds K elements out 
            of the N numbers, the sum of which is exactly S or says it is not possible.
            Example: { 3, 1, 2, 4, 9, 6}, S = 14, K = 3  yes(1 + 2 + 4 = 14)*/

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
            int currentCount = 1, addition = 0;
            bool result1 = false;
            bool result2 = false;
            int[] number = { 3, 1, 2, 4, 9, 6 };
            for (int i = 0; i < array.Length - 1; i++)
            {
                addition += array[i];
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    addition += array[j];
                    currentCount++;
                    if (currentCount == K && addition == sum)
                    {
                        result1 = true;
                    }
                    else
                    {
                        result2 = false;
                    }
                    addition = array[i];
                    currentCount = 1;
                    for (int k = j + 1; k < array.Length; k++)
                    {
                        addition += array[k];
                        currentCount++;
                        if (currentCount == K && addition == sum)
                        {
                            result1 = true;
                        }
                        else
                        {
                            result2 = false;
                        }
                        addition = array[i] + array[j + 1];
                        currentCount = 2;
                    }
                }
                currentCount = 1;
                addition = 0;
            }
            if (result1 == true)
            {
                Console.WriteLine($"The sum of {sum} of elements {K} in the array of {N} is possible. ");
            }
           else if (result2 == false)
           {
                Console.WriteLine($"The sum of {sum} of elements {K} in the array of {N} is NOT possible. ");
           }
        }
    }
}
