using System;

namespace Question_15
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arrayOfLatinLetters = { 'A','B','C','D','E','F','G','H','I','J','K','L','M',
                'N','O','P','Q','R','S','T','U','V','W','X','Y','Z', 'a','b','c','d','e','f','g',
                'h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

            
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            char[] splitedWord = word.ToCharArray();
            
            foreach(var letter in splitedWord)
            {
                for (int i = 0; i < arrayOfLatinLetters.Length - 1; i++)
                {
                    if(arrayOfLatinLetters[i] == letter)
                    {
                        Console.Write($"{i}, ");
                    }
                }
            }
        }
    }
}
