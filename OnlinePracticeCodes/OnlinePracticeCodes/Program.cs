using System;

namespace OnlinePracticeCodes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var i = 0;
            while (i < 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            var random = new Random();
            for (var x = 0; x < 10; x++)
            {
                Console.WriteLine(random.Next(1, 100));
            }

            var random2 = new Random();

            var buffer = new char[10];

            for (var y = 0; y < 10; y ++)
            {
                buffer[y] = (char)('a' + random2.Next(0,26));
            }

            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
