using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which finds the maximal sequence of consecutive
            //equal elements in an array. E.g.: { 1, 1, 2, 3, 2, 2, 2, 1}  { 2, 2, 2}.


            /*int[] array = { 1, 1, 2, 3, 2, 2, 2, 1, };
            int currentCount = 1;
            int maxCount = 0;
            int number = 0;
            int current = 0;
            for(int i = 0;  i < array.Length - 1; i++)
            {
                if(array[i] != array[i + 1])
                {
                    currentCount = 1;
                }
                else
                {
                    currentCount++;
                    if(currentCount > maxCount)
                    {
                        current = array[i];
                        number = current;
                        maxCount = currentCount;
                    }
         
                }
                
            }
            for(int a = 0; a < maxCount; a++)
            {
                Console.Write($", {number}");
            }*/

            int[] array = { 1, 1, 3, 3, 3, 4, 4, 4, 4, 4, 3, 2, 2, 2, 5};
            int currentCount = 1;
            int maxCount = 0;
            int lastIndex = 0;
            int current = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] != array[i + 1])
                {
                    currentCount = 1;
                }
                else
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        current = array[i];
                        lastIndex = array[i + 1];
                        maxCount = currentCount;
                    }

                }

            }
            for (int a = array.Length; a > array.Length - maxCount; a--)
            {
                Console.Write($"{lastIndex}, ");
            }
        }
    }
}
