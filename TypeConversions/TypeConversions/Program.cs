using System;

namespace TypeConversions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //We can convert upto value 255 byte into an integer as follows. 
            //If we change the code below to 256, we will get an error.
            byte b = 251;
            Console.WriteLine(b);
            int i = b;
            Console.WriteLine(i);

            //Conversely, we can only convert an integer upto value 255 to byte.
            //Any value after that, there will be loss of data. But there will be no error message or warning.
            //The "(byte)" in front of x (line 24) is called casting, without it, the computer will get confused.

            int x = 258;
            Console.WriteLine(x);
            byte c = (byte)x;
            Console.WriteLine(c);

            //To convert strings to numbers we use Dotnets builtin library.
            var s = "1234";
            Console.WriteLine(s);
            int d = Convert.ToInt32(s);
            Console.WriteLine(d);

            //To convert a string to byte
            var t = "3";
            Console.WriteLine(t);
            //when I write the code below and run it, it will crash the system.
            //the platform does not explain well why that happens and suggested I do a google search.
            //So I am commenting this code out for now.

            //int e = Convert.ToByte(s);
            //Console.WriteLine(e);

            try
            {
                var u = "23456";
                Console.WriteLine(u);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte!");
            }
            byte number = 255;
            Console.WriteLine(number);
            number += 2;
            Console.WriteLine(number);

        }
    }
}