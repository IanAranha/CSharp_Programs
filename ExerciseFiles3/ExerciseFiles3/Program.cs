using System;
using System.Collections.Generic;

namespace ExerciseFiles3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // #1 When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
            //If no one likes your post, it doesn't display anything.
            //If only one person likes your post, it displays: [Friend's Name] likes your post.
            //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
            //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.

            //Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
            //Depending on the number of names provided, display a message based on the above pattern.


            var names = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter a name and press Enter (or hit Enter to exit):");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);

            }
            if (names.Count > 2)
                Console.WriteLine("{0}, {1}, and {2} other people like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post)", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine(names[0] + " likes your post.");
            else
                Console.WriteLine();



            //Write a program and ask the user to enter their name. 
            //Use an array to reverse the name and then store the result in a new string. 
            //Display the reversed name on the console.
            Console.Write("What is your name? ");
            var name = Console.ReadLine();

            var nameArray = new char[name.Length];

            for (var i = name.Length; i > 0; i--)
                nameArray[name.Length - i] = name[i - 1];

            var reversed = new string(nameArray);
            Console.WriteLine("Reversed name: " + reversed);

            //Write a program and ask the user to enter 5 numbers.
            //If a number has been previously entered, display an error message and ask the user to re-try. 
            //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("Number already exists, enter new number");
                    continue;
                }
                numbers.Add(number);
            }
            numbers.Sort();
            foreach (var numb in numbers)
            {
                Console.WriteLine(numb);
            }

            //Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
            //The list of numbers may include duplicates.Display the unique numbers that the user has entered.

            var numbers2 = new List<int>();
            while (true)
            {
                Console.Write("Enter a number or type 'Quit' to exit: ");
                var input2 = Console.ReadLine();
                if (input2.ToLower() == "quit")
                    break;
                numbers2.Add(Convert.ToInt32(input2));
            }

            Console.WriteLine("Entered numbers: ");
            foreach (var number in numbers2)
                Console.WriteLine(number);

            var uniques = new List<int>();
            foreach (var number in numbers2)
                if (!uniques.Contains(number))
                    uniques.Add(number);

            Console.WriteLine("Unique numbers:");
            foreach (var number in uniques)
                Console.WriteLine(number);

            //Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
            //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
            //otherwise, display the 3 smallest numbers in the list.



        }
    }
}
