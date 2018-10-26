using System;

namespace Conditionals
{
    public enum Season
    {
        Spring, 
        Summer,
        Autumn,
        Winter
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //This is an example of a multistep if/else conditional method.
            int hour = 3;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It is morning");
            }
            else if (hour > 12 && hour < 16)
            {
                Console.WriteLine("It is afernoon");
            }
            else if (hour > 16 && hour < 20)
            {
                Console.WriteLine("It is evening");
            }
            else if (hour > 20 && hour < 24)
            {
                Console.WriteLine("It is night");
            }
            else
            {
                Console.WriteLine("invalid time entered.");
            }

            //These two conditional methods work exactly the same way.
            //Method 1, traditional spelled out

            bool isGoldCustomer = true;
            float price;
            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }
            Console.WriteLine(price);

            //Method 2
            //Spiced up and a lot smaller code.

            float price2 = (isGoldCustomer) ? 15.45f : 19.35f;
            Console.WriteLine(price2);



            //Conditional method showing switch(case). 
            //Data for this class is in a separate class.


            var season = Season.Summer;

            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("It is a beautiful Autumn day");
                    break;

                case Season.Spring:
                    Console.WriteLine(("It is a beautif Spring day"));
                    break;

                case Season.Winter:
                    Console.WriteLine(("It is a beautif Winter day"));
                    break;

                default:
                    Console.WriteLine("I dont undertand that season.");
                    break;
            }
        }
    }
}
