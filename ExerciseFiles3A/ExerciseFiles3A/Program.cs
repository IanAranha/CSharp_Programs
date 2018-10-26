using System;
using System.Collections.Generic;

namespace ExerciseFiles3A
{

    class MainClass
    {
        //When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
        //If no one likes your post, it doesn't display anything.
        //******If only one person likes your post, it displays: [Friend's Name] likes your post.
        //******If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
        //******If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
        //Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
        //Depending on the number of names provided, display a message based on the above pattern.

        static void Exercise1()
        {
            var names = new List<string>();
            while(true)
            {
                Console.WriteLine("Enter a name or hit enter to exit");
                var input = Console.ReadLine();
                if(String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    names.Add(input);
                }
            }
            if (names.Count == 1)
                Console.WriteLine(names[0]+ " likes your post");
            if (names.Count == 2)
                Console.WriteLine(names[0] + " and " + names[1] + " like your post");
            var counter = names.Count - 2;
            if (names.Count > 2)
                Console.WriteLine(names[0] + "," + names[1] + " and "+ counter + " others like your post");
        }

        //Write a program and ask the user to enter their name. 
        //Use an array to reverse the name and then store the result in a new string. 
        //Display the reversed name on the console.
        static void Exercise2()
        {
            Console.WriteLine("Enter your name: ");
            var input = Console.ReadLine();
            var array = new char[input.Length];

            for (var i = input.Length; i > 0; i--)
            {
                array[input.Length - i] = input[i - 1];
            }

            var reversed = new string(array);
            Console.WriteLine("Reversed: " + reversed);
        }

        //Write a program and ask the user to enter 5 numbers. 
        //If a number has been previously entered, display an error message and ask the user to re-try. 
        //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.


        static void Exercise3()
        {
            var numbers = new List<int>();
            while(numbers.Count < 5)
            {
                Console.WriteLine("Enter a number: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(input))
                {
                    Console.WriteLine("Number already in the array");
                    continue;
                }
                else
                {
                    numbers.Add(input);
                }
            }
            Console.WriteLine("The original numbers are: ");
            for (var i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            numbers.Sort();
            Console.WriteLine("The sorted numbers are: ");
            for (var i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            numbers.Reverse();
            Console.WriteLine("The reversed numbers are: ");
            for (var i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
        // Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
        //The list of numbers may include duplicates. 
        //Display the unique numbers that the user has entered.

        static void Exercise4()
        {
            var numbers = new List<int>();
            while(true)
            {
                Console.WriteLine("Enter a number to add to the list: ");
                var input = Console.ReadLine();
                if(input.ToLower() == "quit")
                    break;
                else
                    numbers.Add(Convert.ToInt32(input));
            }
            var uniques = new List<int>();
            foreach(var num in numbers)
            {
                if (!uniques.Contains(num))
                    uniques.Add(num);
            }
            Console.WriteLine("Unique numbers added: ");
            foreach( var num in uniques)
            {
                Console.WriteLine(num);
            }
            uniques.Sort();
            Console.WriteLine("Unique numbers sorted: ");
            foreach (var num in uniques)
            {
                Console.WriteLine(num);
            }

        }

        //Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
        //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
        //otherwise, display the 3 smallest numbers in the list.
        static void Exercise5()
        {
            string[] elements;
            while(true)
            {
                Console.WriteLine("Enter at least 5 numbers separted by a comma:");
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }
                Console.WriteLine("Invalid List");
            }
            var numbers = new List<int>();
            foreach (var num in elements)
                numbers.Add(Convert.ToInt32(num));
            numbers.Sort();
            Console.WriteLine("The three smallest numbers are {0}, {1} and {2}.", numbers[0], numbers[1], numbers[2]);

            //Alternately
            var smallest = new List<int>();
            while(smallest.Count <= 3)
                foreach (var num in numbers)
                    if (!smallest.Contains(num))
                        smallest.Add(num);
            Console.WriteLine("The three smallest unique numbers are {0}, {1} and {2}.", smallest[0], smallest[1], smallest[2]);

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4()
            Exercise5();
        }
    }
}
