using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3};
            int count = 0, max = 0, number = 0;
           for(int i = 0; i < array.Length; i++)
           {
                for(int j = 0; j < array.Length; j++)
                {
                    if(array[i] == array[j])
                    {
                        count++;
                        if(count > max)
                        {
                            max = count;
                            number = array[j];
                        }
                    }
                }
           }
           for(int a = 0; a < max; a++)
           {
                Console.Write($"{a}, ");
           }
        }
    }
}
