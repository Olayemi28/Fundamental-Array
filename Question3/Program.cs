using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program, which compares two arrays of type char
            // lexicographically (character by character) and checks, which one is first 
            // in the lexicographical order.

            bool isEqual1 = false;
            bool isEqual2 = false;
            Console.Write("Enter the length of  the array:");
            int length1;
            while (!(int.TryParse(Console.ReadLine(), out length1)))
            {
                Console.Write("Kindly enter a number:");
            }
            char[] array1 = new char[length1];
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("input = ");
                array1[i] = char.Parse(Console.ReadLine());
            }

            Console.Write("Enter the length of  the array:");
            int length2;
            while (!(int.TryParse(Console.ReadLine(), out length2)))
            {
                Console.Write("Kindly enter a number:");
            }
            char[] array2 = new char[length2];
            for (int j = 0; j < array2.Length; j++)
            {
                Console.Write("input = ");
                array2[j] = char.Parse(Console.ReadLine());
            }

            int small = array1.Length < array2.Length ? array1.Length : array2.Length;
            for(int i = 0;i < small; i++)
            {
                if(array1[i] < array2[i])
                {
                    Console.WriteLine(string.Join("", array1));
                    break;
                }
                else 
                {
                    Console.WriteLine(string.Join("", array2));
                    break;
                }
            }

                //     int count = 0;
                //     int smaller = ((array1.Length + array2.Length) - Math.Abs(array1.Length - array2.Length)) / 2;
                    
                //     for (int a = 0; a < smaller; a++)
                //     {
                //         if (array1[a] < array2[a])
                //         {
                //             isEqual1 = true;
                //             break;
                //         }
                //         else if (array1[a] > array2[a])
                //         {
                //             isEqual2 = true;
                //             break;
                //         }
                //         else
                //         {
                //             count++;
                //         }
                //     }
                //     if (isEqual1 == true)
                //     {
                //         Console.WriteLine("Array one comes first in the lexicographical order");
                //     }
                //     else if (isEqual2 == true)
                //     {
                //         Console.WriteLine("Array two comes first in the lexicographical order");
                //     }
                //    else if (count == smaller && array1.Length == smaller && array2.Length > array1.Length)
                //     {
                //         Console.WriteLine("Array one come first in the lexicographical order");
                //     }
                //     else if (count == smaller && array2.Length == smaller && array1.Length > array2.Length)
                //     {
                //         Console.WriteLine("Array two come first in the lexicographical order");
                //     }
        
                //     else
                //     {
                //         Console.WriteLine("The two arrays are equal");
                //     }


             
        }

    }
}
