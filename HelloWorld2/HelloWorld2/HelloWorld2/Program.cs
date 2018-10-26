using System;

namespace HelloWorld2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            const float pi = 3.14f;
            var r = 20;
            var area = pi * r * r;
            Console.WriteLine("The Area is: " + area);
            byte number = 255;
            Console.WriteLine("The first instance of 'number' is:" + number);
            number += 1;
            Console.WriteLine("After adding one, number becomes: "+ number);
        }
    }
}
