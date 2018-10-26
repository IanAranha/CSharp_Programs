using System;


namespace ExerciseFiles1A
{
    class MainClass
    {
        public enum imageOrientation
        {
            Landscape,
            Portrait,
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Write a program and ask the user to enter a number.
            //The number should be between 1 to 10.     

            //If the user enters a valid number, display "Valid" on the console. 
            //Otherwise, display "Invalid".

            Console.WriteLine("Enter a number between 1 & 10: ");
            var input = Console.ReadLine();
            var result = Convert.ToInt32(input);

            if (result > 0 && result < 10)
            {
                Console.WriteLine("Valid!");
            }
            else
            {
                Console.WriteLine("Invalid Number!");
            }


            //Write a program which takes two numbers from the console and displays the maximum of the two.

            Console.WriteLine("Enter number 1: ");
            var result1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            var result2 = Convert.ToInt32(Console.ReadLine());

            if (result1 > result2)
            {
                Console.WriteLine(string.Format("The larger number is : {0}", result1));
            }
            else
            {
                Console.WriteLine(string.Format("The larger number is : {0}", result2));
            }

            //Alternately
            var max = (result1 > result2) ? result1 : result2;
            Console.WriteLine("The max is: " + max);


            //Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

            Console.WriteLine("Enter width: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine(string.Format("Picture is landscape"));
            }
            else
            {
                Console.WriteLine(string.Format("Picture is Portrait"));
            }
            // Alternately:

            var displayStyle = (width > height) ? imageOrientation.Landscape : imageOrientation.Portrait;
            Console.WriteLine("image is: " + displayStyle);

            //Your job is to write a program for a speed camera. 
            //Write a program that asks the user to enter the speed limit.
            Console.WriteLine("Speed Limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            //Once set, the program asks for the speed of a car. 
            Console.WriteLine("Current Speed: ");
            //If the user enters a value less than the speed limit, program should display Ok on the console. 
            var current_speed = Convert.ToInt32(Console.ReadLine());
            if (current_speed < speedLimit)
            {
                Console.WriteLine("OK");
            }
            //If the value is above the speed limit, the program should calculate the number of demerit points. 
            //For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
            //If the number of demerit points is above 12, the program should display License Suspended.
            else
            {
                var excessSpeed = current_speed - speedLimit;
                Console.WriteLine("{0} mph above the posted speed limit.", excessSpeed);
                const int kmphoverspeedlimit = 5;
                var demerits = excessSpeed / kmphoverspeedlimit;

                if (demerits < 12)
                {
                    Console.WriteLine("Demerits: {0}", demerits);
                }
                else
                {
                    Console.WriteLine("License is suspended.");

                }
            }
        }
    }
}
