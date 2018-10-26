using System;
using System.Collections.Generic;

namespace ExerciseFiles4
{
    class MainClass
    {
        //Write a program and ask the user to enter a few numbers separated by a hyphen. 
        //Work out if the numbers are consecutive. 
        //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
        static void Exercise1()
        {
            Console.WriteLine("Enter a series of numbers separated by hyphen: ");
            var input = Console.ReadLine();
            var num = input.Split('-');
            var numbers = new List<int>();
            foreach (var i in num)
                numbers.Add(Convert.ToInt32(i));
            foreach (var i in numbers)
                Console.WriteLine(i);
            numbers.Sort();
            var isConsequtive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsequtive = false;
                    break;
                }
            }
            var message = isConsequtive ? "Consequtive" : "Not Consecutive ";
            Console.WriteLine(message);
        }
        //Write a program and ask the user to enter a few numbers separated by a hyphen. 
        //If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. 
        //If so, display "Duplicate" on the console.
        static void Exercise2()
        {
            Console.WriteLine("Enter a series of numbers separatd by hyphen:");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Cannot be blank");
                return;
            }
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
            if (duplicateflag)
            {
                Console.WriteLine("Duplicates found");
            }

            else
            {
                Console.WriteLine("No Duplicates found");
            }
        }

        //Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
        //A valid time should be between 00:00 and 23:59. 
        //If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
        //If the user doesn't provide any values, consider it as invalid time. 

        static void Exercise3()
        {
            Console.WriteLine("Enter a Valid time: HH:mm");
            var input = Console.ReadLine();
            if(String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            var time = new List<int>();
            var num = input.Split(':');
            if(num.Length != 2)
            {
                Console.WriteLine("Invalid time");
                return;
            }
            try
            {
                var hour = Convert.ToInt32(num[0]);
                var min = Convert.ToInt32(num[1]);
                if(hour >= 0 && hour <= 23 && min >= 0 && min <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid time");
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid time");
            }
        }


        //Write a program and ask the user to enter a few words separated by a space. 
        //Use the words to create a variable name with PascalCase. 
        //For example, if the user types: "number of students", display "NumberOfStudents".
        //Make sure that the program is not dependent on the input. 
        //So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

        static void Excersise4()
        {
            Console.WriteLine("Enter a few words separatd by space");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid String");
                return;
            }

            var variableName = "";
            foreach(var word in input.Split(' '))
            {
                var WordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += WordWithPascalCase;
            }
            Console.WriteLine(variableName);
 
        }

        //Write a program and ask the user to enter an English word. 
        //Count the number of vowels (a, e, o, u, i) in the word. 
        //So, if the user enters "inadequate", the program should display 6 on the console.

        static void Exercise5()
        {
            var totalCount = 0;
            Console.WriteLine("Enter a word: ");
            var input = Console.ReadLine();
            var input2 = input.ToLower();            //This command is added for the second program written below (Code is cleaner)
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid String");
                return;
            }
            var lowerCaseWord = input.ToLower();
            for (var i = 0; i < lowerCaseWord.Length; i++)
            {
                if(lowerCaseWord[i] == 'a')
                    totalCount += 1;
                if (lowerCaseWord[i] == 'e')
                    totalCount += 1;
                if (lowerCaseWord[i] == 'i')
                    totalCount += 1;
                if (lowerCaseWord[i] == 'o')
                    totalCount += 1;
                if (lowerCaseWord[i] == 'u')
                    totalCount += 1;
            }
                
            Console.WriteLine("Total vowels: "+totalCount);
            //Alternately
            //Console.WriteLine("Enter a word: ");
            var vowels = new List<char>(new char[]{'a','e','i','o','u'});
            var vowelCounter = 0;
            foreach (var character in input2)
                if (vowels.Contains(character))
                    vowelCounter += 1;
            Console.WriteLine("Second count: "+vowelCounter);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Excersise4();
            Exercise5();
        }
    }
}
 