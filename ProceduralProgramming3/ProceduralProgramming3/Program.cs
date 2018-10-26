using System;
using System.Collections.Generic;

namespace ProceduralProgramming3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Exercise3();
        }
        //Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
        //A valid time should be between 00:00 and 23:59. 
        //If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
        //If the user doesn't provide any values, consider it as invalid time. 

        public static void Exercise3()
        {
            Console.WriteLine("Enter a Valid time: HH:mm");
            var input = Console.ReadLine();

            var message = CheckTime(input);

            Console.WriteLine(message);

        }

        public static string CheckTime(String input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                var message = "Invalid Time - Cannot be blank or null";
                return message ;
            }

            var time = new List<int>();
            var num = input.Split(':');
            if (num.Length != 2)
            {
                var message = "Invalid Time - Can only enter HH : mm ";
                return message;
            }
            try
            {
                var hour = Convert.ToInt32(num[0]);
                var min = Convert.ToInt32(num[1]);
                if (hour >= 0 && hour <= 23 && min >= 0 && min <= 59)
                {
                    var message = "Ok";
                    return message;
                }
                else
                {
                    var message = ("Invalid time");
                    return message;
                }
            }
            catch (Exception)
            {
                var message = "Invalid time";
                return message;
            }
        }

    }
}
