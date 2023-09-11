using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program, which reads two arrays from the console and checks 
            // whether they are equal (two arrays are equal when they are of equal 
            // length and all of their elements, which have the same index, are equal).

            bool isLength = true;

            Console.Write("Enter the length of the first array:");
            int length1 = int.Parse(Console.ReadLine());

            int[] array1 = new int[length1];

            for(int i = 0; i < array1.Length; i++)
            {
                Console.Write("Enter the element:");
                array1[i] = int.Parse(Console.ReadLine());
            }


            Console.Write("Enter the length of the second array:");
            int length2 = int.Parse(Console.ReadLine());

            int[] array2 = new int[length2];

            for(int j = 0; j < array2.Length; j++)
            {
                Console.Write("Enter the element:");
                array2[j] = int.Parse(Console.ReadLine());
            }

           if(array1.Length == array2.Length)
           {
                for (int i = 0; i < array1.Length; i++)
                {
                    if(array1[i] != array2[i])
                    {
                        isLength = false;
                        break;
                    }
                }
                if (isLength == true)
                {
                    Console.WriteLine("The length and the element of the arrays are equal.");
                }
                else
                {
                    Console.WriteLine("The lenth of the arrays are equal but the element are not.");
                }
           }
            else
            {
                Console.WriteLine("The length of the arrays are not equal.");
            }
            
        }
    }
}
