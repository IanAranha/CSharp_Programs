using System;
using System.Collections.Generic;

namespace ProceduralProgramming2
{
    class MainClass
    {
        //Write a program and ask the user to enter a few numbers separated by a hyphen. 
        //If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. 
        //If so, display "Duplicate" on the console.
        public static void Exercise2()
        {
            Console.WriteLine("Enter a series of numbers separatd by hyphen:");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Cannot be blank");
                return;
            }
            var message = DuplicateFinder(input);
            Console.WriteLine(message);
        }

        public static string DuplicateFinder(String input)
        {
            var numbers = new List<int>();

            foreach (var n in input.Split('-'))
                numbers.Add(Convert.ToInt32(n));

            numbers.Sort();

            var singles = new List<int>();

            var duplicateflag = false;
            foreach (var i in numbers)
                if (!singles.Contains(i))
                {
                    singles.Add(i);
                }
                else
                {
                    duplicateflag = true;
                    break;
                }

            var message = (duplicateflag) ? "Duplicates found" : "No duplicates";
            return message;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Exercise2();
        }


    }
}
