using System;

namespace ExerciseFiles2A
{
    class MainClass
    {
        //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
        static void DivisibleBythree()
        {
            var counter = 0;
            for (var i= 1; i< 100; i++)
            {
                if(i % 3 == 0)
                {
                    counter += 1;
                }
            }
            Console.WriteLine(counter);
        }

        //Write a program and continuously ask the user to enter a number or "ok" to exit. 
        //Calculate the sum of all the previously entered numbers and display it on the console.
        static void SumOfNumbers()
        {
            var sum = 0;
            while(true)
            {
                Console.WriteLine("Enter a number or 'OK' to exit: ");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                    break;
                else
                    sum += Convert.ToInt32(input);
                Console.WriteLine("The current sum is {0}", sum);
            }
        }

        //Write a program and ask the user to enter a number. 
        //Compute the factorial of the number and print it on the console. 
        //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        static void Factorial()
        {
            Console.WriteLine("Enter a number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var result = 1;
            for (var i = input; i > 0; i--)
            {
                result *= i;
            }
            Console.WriteLine("{0}! = {1}", input, result);
        }

        //Write a program that picks a random number between 1 and 10. 
        //Give the user 4 chances to guess the number. 
        //If the user guesses the number, display “You won"; otherwise, display “You lost". 
        //(To make sure the program is behaving correctly, you can display the secret number on the console first.)

        static void GuessTheNumber()
        {
            var random = new Random();
            var number = Convert.ToInt32(random.Next(1, 10));
            var counter = 0;
            while(counter < 4)
            {
                Console.WriteLine("Enter your guess: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == number)
                {
                    Console.WriteLine("Correct");
                    break;
                }
                else 
                {
                    Console.WriteLine("Wrong");
                    counter += 1;
                }
            }
        }


        //Write a program and ask the user to enter a series of numbers separated by comma. 
        //Find the maximum of the numbers and display it on the console. 
        //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

        static void GuessTheMax()
        {
            //Display the invite to enter the data
            Console.WriteLine("Enter a series of numbers separated by a comma:");

            //Accept the input as a string
            var input = Console.ReadLine();
           
            //Split each member of the string into an array delimited by a comma. The elements are still strings.
            var numbers = input.Split(',');

            //Set a variable max to the first element of the array in integer form
            var max = Convert.ToInt32(numbers[0]);

            //Iterate from the next element of the array, convert it to interger form and compare it to max. If that number is bigger than max, max becomes the element.
            for (int i = 1; i < numbers.Length; i++)
            {
                if (Convert.ToInt32(numbers[i]) > max)
                    max = Convert.ToInt32(numbers[i]);
            }

            //Display the results
            Console.WriteLine("The max number you have entered is "+max);


            //This is an alternate approach to the last loop in this program
            foreach(var num in numbers)
            {
                var thisNumber = Convert.ToInt32(num);
                if (thisNumber > max)
                {
                    max = thisNumber;
                }
            }
            Console.WriteLine("The maximum number you have entered is " + max);
        }



        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DivisibleBythree();
            SumOfNumbers();
            Factorial();
            GuessTheNumber();
            GuessTheMax();
        }
    }
}
