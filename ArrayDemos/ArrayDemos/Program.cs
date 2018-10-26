using System;

namespace ArrayDemos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var numbers = new int[] {54,41,97,342,22,94 };

            //Length
            Console.WriteLine("Lenght of array: " + numbers.Length);

            //IndexOf
            var index = Array.IndexOf(numbers, 97);
            Console.WriteLine("The index of 34 is: " + index);

            //Clear()
            Array.Clear(numbers, 2, 2);
            foreach(var n in numbers)
                Console.WriteLine(n);

            //Copy()
            var newArray = new int[3];
            Array.Copy(numbers, newArray, 3);
            foreach( var m in newArray)
                Console.WriteLine(m);

            //Sort()
            foreach (var n in numbers)
                Console.WriteLine(n);
            Array.Sort(numbers);
            foreach(var n in numbers)
                Console.WriteLine(n);

            //Reverse()
            Array.Reverse(numbers);
            foreach(var n in numbers)
                Console.WriteLine(n);

        }
    }
}
