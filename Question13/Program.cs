using System;

namespace Question_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program, which creates a rectangular array with size of n by m
            elements.The dimensions and the elements should be read from the
            console.Find a platform with size of(3, 3) with a maximal sum.*/

            int biggestSum = int.MinValue, bigRow = 0, bigCol = 0, sum = 0;

            Console.Write("Enter the number of rows:");
            int rows;
            while (!(int.TryParse(Console.ReadLine(), out rows) && rows > 2))
            {
                Console.Write("Kindly enter a number:");
            }
            Console.Write("Enter the number of columns:");
            int cols;
            while (!(int.TryParse(Console.ReadLine(), out cols) && cols > 2))
            {
                Console.Write("Kindly enter a number:");
            }
            int[,] myArray = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"myArray[{i}, {j}]:");
                    myArray[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < myArray.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < myArray.GetLength(1) - 2; col++)
                {
                    sum = myArray[row, col] + myArray[row, col + 1] + myArray[row, col + 2]
                        + myArray[row + 1, col] + myArray[row + 1, col + 1] + myArray[row + 1, col + 2];
                    if (sum > biggestSum)
                    {
                        biggestSum = sum;
                        bigRow = row;
                        bigCol = col;
                    }
                }
            }

            Console.WriteLine($"The best platform is:");
            Console.WriteLine($"{myArray[bigRow, bigCol]} {myArray[bigRow, bigCol + 1]} {myArray[bigRow, bigCol + 2]}");
            Console.WriteLine($"{myArray[bigRow + 1, bigCol]} {myArray[bigRow + 1, bigCol + 1]} {myArray[bigRow + 1, bigCol + 2]}");
            Console.WriteLine($"The best sum is: {biggestSum}");

        }
    }
}
