using System;

namespace Question_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100; 
            int[] array = {34, 12, 76, 1, 23, 89, 45, 56, 9};
            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] > array[j])
                    {
                        int saveElement = array[i];
                        array[i] = array[j];
                        array[j] = saveElement;
                    }
                }
            }
            foreach (var item in array)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine(" ");
            int low = 0, high = array.Length - 1;
            bool result = false;
            while(low <= high)
            {
                int mid = (low + high) / 2;
                if(array[mid] == x)
                {
                    Console.Write(mid);
                    result = true;
                    break;
                }
                else if(array[mid] > x)
                {
                    high = mid - 1;
                }
                else if(array[mid] < x)
                {
                    low = mid + 1;
                }
            }
            if(result == false)
            {
                Console.WriteLine("-1");
            }
        }
    }
}
