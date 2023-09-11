using System;

namespace Question_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program, which creates square matrices like those in the 
            // figures below and prints them formatted to the console. The size of the 
            // matrices will be read from the console. See the examples for matrices 
            // with size of 4 x 4 and make the other sizes in a similar fashion:

            //12a.
            // int[,] number = new int[4,4];
            // for(int i = 0; i < 4; i++)
            // {
            //     for(int j = 0, l = 1; j < 4; j++)
            //     {
            //         number[i,j] = i + j + l;
            //         l += 3;
            //     }
            // }
            // for(int a = 0; a < 4; a++)
            // {
            //     for(int b = 0; b < 4; b++)
            //     {
            //         Console.Write(number[a,b] + " ");
            //     }
            //     Console.WriteLine();
            // }

            //=================================================================
            //12b.
            // int[,] number = new int[4,4];
            // for(int i = 0, k = 7, l = 1; i < 4; i++)
            // {
            //     for(int j = 0; j < 4; j++)
            //     {
            //         if (j == 0)
            //         {
            //             number[i,j] = i + j + 1;
            //         }
            //         else if(j % 2 == 0)
            //         {
            //             number[i,j] = number[i, j - 1] + l;
            //         }
            //         else if(j % 2 != 0)
            //         {
            //             number[i,j] = number[i, j - 1] + k;
            //         }
            //     }
            //     k -= 2;
            //     l += 2;
            // }
            // for(int a = 0; a < 4; a++)
            // {
            //     for(int b = 0; b < 4; b++)
            //     {
            //         Console.Write(number[a,b] + " ");
            //     }
            //     Console.WriteLine();
            // }

            //===================================================================
            //12c.

        }
    }
}
