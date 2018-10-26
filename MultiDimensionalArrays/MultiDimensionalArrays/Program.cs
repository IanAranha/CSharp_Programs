using System;

namespace MultiDimensionalArrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var matrix = new int[3, 5]
            {
                {1,2,3,4,5},
                {6,7,8,9,10},
                {11,12,13,14,15}
            };

            var element = matrix[2, 3];
            Console.WriteLine(element);
            element = matrix[0,0];
            Console.WriteLine(element);
            element = matrix[1, 4];
            Console.WriteLine(element);

        }
    }
}
