using System;

namespace ExcerciseFiles1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
         
            Console.WriteLine("Enter a number between 1 and 10:  ");

            //Learning a new commmand to input/accept a value on console.
            var input = Console.ReadLine();

            //Console inputs are all strings and need to be converted to int type for operations.
            var number = Convert.ToInt32(input);


            //Simple command to show string and int concantations and int and int operation
            var a = input + number;
            var b = number + number;
            Console.WriteLine(a);
            Console.WriteLine(b);
           

            //this is the code that the exercise asked for:

            if (number > 0 && number < 11)
            {
                Console.WriteLine("The number is valid.");
            }
            else
            {
                Console.WriteLine("The number is not valid.");
            }

            //Excercise 2
            Console.WriteLine("Now enter two numbers");
            Console.WriteLine("Enter first number");
            var stringnum1 = Console.ReadLine();
            var num1 = Convert.ToInt32(stringnum1);
            Console.WriteLine("Enter second number");
            var stringnum2 = Console.ReadLine();
            var num2 = Convert.ToInt32(stringnum2);
            if (num1 > num2)
            {
                Console.WriteLine(string.Format("The larger number is {0}.", num1));
            }
            else
            {
                Console.WriteLine(string.Format("The larger number is {0}.", num2));
            }

            //Exercise 3:
            Console.WriteLine("Enter the width of the image: ");
            var width = Console.ReadLine();
            var c_width = Convert.ToInt32(width);
            Console.WriteLine("Enter the height of the image: ");
            var height = Console.ReadLine();
            var c_height = Convert.ToInt32(height);
            if(c_height > c_width)
            {
                Console.WriteLine("The imagage is set to Portrait mode");
            }
            else
            {
                Console.WriteLine("The image is set to landscape");
            }

            //Exercise #4
            Console.WriteLine("Enter legal speed limit:     mph");
            var sl = Console.ReadLine();
            var speedlimit = Convert.ToInt32(sl);

            Console.WriteLine("Enter vehicle speed:       mph");
            var speed = Console.ReadLine();
            var vehicle_speed = Convert.ToUInt32(speed);

            if (vehicle_speed <= speedlimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                var excess_speed = vehicle_speed - speedlimit;
                Console.WriteLine(excess_speed);
                var demerits = (excess_speed / 5);
                if (demerits > 12)
                {
                    Console.WriteLine("Driver's License suspended.");
                }
                else
                {
                    Console.WriteLine(string.Format("Driver gets {0} demerits.", demerits));
                }

            }

        }
    }
}
