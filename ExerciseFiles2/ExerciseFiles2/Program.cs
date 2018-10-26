using System;

namespace ExerciseFiles2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var count = 0;
            for (var i = 0; i <= 1000000; i++)
            {
                if(i%3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("There are {0} numbers that are divisible by 3", count);

            //2- Write a program and continuously ask the user to enter a number or "ok" to exit. 
            //Calculate the sum of all the previously entered numbers and display it on the console.
          
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or ok to exit): ");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                    break;
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("The sum of numbers input : {0}", sum);









            //Write a program and ask the user to enter a number. 
            //Compute the factorial of the number and print it on the console. 
            //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            var factorial = 1;
            Console.Write("Enter a number: ");
            var input2 = Console.ReadLine();
            var number = Convert.ToInt32(input2);
            for (var i = number; i > 0; i--)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("{0}! is {1}", input2, factorial);


            //4- Write a program that picks a random number between 1 and 10. 
            //Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; 
            //otherwise, display “You lost".
            var random = new Random();
            var myNumber = random.Next(1, 10);
            Console.WriteLine(myNumber);
            Console.WriteLine("I have picked a random number between 1 and 10");
            Console.WriteLine("You have four chances to guess the number.");
            for (var i = 0; i < 4; i++)
            {
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == myNumber)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }
            Console.WriteLine("You Lost!");

            //Write a program and ask the user to enter a series of numbers separated by comma. 
            //Find the maximum of the numbers and display it on the console.
            Console.WriteLine("Enter a series of numbers separated by commas");
            var input3 = Console.ReadLine();
            var numbers = input3.Split(',');
            var max = Convert.ToInt32(numbers[0]);
            foreach (var str in numbers)
            {
                var thisnumber = Convert.ToInt32(str);
                if (thisnumber > max)
                    max = thisnumber;
            }
            Console.WriteLine("The max value entered is {0}", max);

        }
    }
}
