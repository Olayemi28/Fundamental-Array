﻿using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program, which creates an array of 20 elements of type 
            // integer and initializes each of the elements with a value equals to the 
            // index of the element multiplied by 5. Print the elements to the console.
            
            int[] array = new int[20];
            int save = 0;
            for(int a = 1; a <= array.Length; a++)
            {
                save = a * 5;
                Console.Write($"{save}, ");
            }
            
        }
    }
}
