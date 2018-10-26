using System;
using System.Collections.Generic;

namespace ProceduralProgramming5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Exercise5();
        }

        public static void Exercise5()
        {
            Console.WriteLine("Enter a word: ");
            var input = Console.ReadLine();
            var message = CountTheVowels(input);
            Console.WriteLine(message);
        }

        public static string CountTheVowels(String input)
        {
            var str = input.ToLower();  
            if (String.IsNullOrWhiteSpace(input))
            {
                var message = "Invalid String";
                return message;
            }

            var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });

            var vowelCounter = 0;

            foreach (var character in str)
                if (vowels.Contains(character))
                    vowelCounter += 1;
            return "Total number of vowels: " + vowelCounter;
        }
    }
}
