using System;
using System.Collections.Generic;

namespace ListDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var numbers = new List<int>();
            foreach(var number in numbers)
                Console.WriteLine(number);
            numbers.Add(1);

            foreach (var number in numbers)
                Console.WriteLine(number);

            for (var i = 2; i <=10; i++)
                numbers.Add(i);

            foreach (var number in numbers)
                Console.WriteLine(number);

            numbers.AddRange(new int[3] { 22, 33, 44 });

            foreach (var number in numbers)
                Console.WriteLine(number);

            var index = numbers.IndexOf(22);
            Console.WriteLine("The first index of '22' is: "+ index);
            numbers.Add(22);
            Console.WriteLine("The last index of 22 is: " + numbers.LastIndexOf(22));
            Console.WriteLine("Total number of items: "+ numbers.Count);

            foreach (var number in numbers)
                Console.WriteLine(number);

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 22)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine("There are now {0} elements in the list.", numbers.Count);

            numbers.Clear();
            Console.WriteLine("There are now {0} elements in the list.", numbers.Count);
        }
    }
}
