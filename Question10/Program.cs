using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program, which finds the most frequently occurring element in 
            an array. Example: { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4(5 times)*/
            int count = 1, maxCount = 0, current = 0, lastIndex = 0;
            Console.Write("Enter num:");
            int length;
            while(!(int.TryParse(Console.ReadLine(), out length)))
            {
                Console.Write("Kindly enter a number:");
            }
            int[] array = new int[length];
            for(int i = 0; i <= array.Length - 1; i++)
            {
                Console.Write($"array[{i}]:");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= array.Length - 1; i++)
            {
                count = 1;
                for (int j = i + 1; j <= array.Length - 1; j++)
                {
                    if(array[i] == array[j])
                    {
                        count++;
                        if (count >= maxCount)
                        {
                            current = array[i];
                            maxCount = count;
                            lastIndex = current;
                        }
                    }
                }
            }
            Console.Write($"{lastIndex}, {maxCount} times");
        }
    }
}
