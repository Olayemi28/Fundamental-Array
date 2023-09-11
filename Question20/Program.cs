using System;

namespace Question_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter Sum: ");
            int sum = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"array[{i}]");
                array[i] = int.Parse(Console.ReadLine());
            }

            int addition = 0, lastIndex = 0, maxCount = 0, currentCount = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                addition += array[i];
                for (int j = 0; j < array.Length - 1; j++)
                {
                    addition += array[j];
                    if(addition == sum)
                    {
                        lastIndex = j;
                    }
                }
                addition = 0;
            }
        }
    }
}
