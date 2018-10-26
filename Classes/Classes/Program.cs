using System;
using Classes.Math;

namespace Classes
{
    public enum ShippingMethods
    {
        RegularAirMai = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var person = new Person();
            person.firstName = "Ian";
            person.lastName = "Aranha";
            person.Introduce();

            var calc = new Calculator();
            var results = calc.Add(5,6);
            Console.WriteLine(results);

            results = calc.Subtract(10, 3);
            Console.WriteLine(results);

            results = calc.Multiply(33, 11);
            Console.WriteLine(results);


            //I need to work on this part of the calculator problem.
            //results = calc.Divide(33,7);
            Console.WriteLine(results);


            // Instead of starting a new file for "Strings", I am lazy and am practicing the code from the online demo here.
            //Shows two different ways to manipulate strings.
            var firstName = "Ian";
            var lastName = "Aranha";

            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            var myfullName = string.Format("My full name is {0} {1}", firstName, lastName);
            Console.WriteLine(myfullName);

            //The following code access information from the enum class ShippingMethod above.
            var methods = ShippingMethods.Express;
            //The following code will display Express.
            Console.WriteLine(methods);
            Console.WriteLine(methods.ToString());

            //The following code casts express into interger value
            Console.WriteLine((int)methods);
            //another way


            //The following code is reverse of the above.
            var methodId = 3;
            Console.WriteLine((ShippingMethods)methodId);

            //Demo for value and structure types
            //value types are independant of each other
            var a = 10;
            var b = a;
            Console.WriteLine(b);
            b++;
            Console.WriteLine(b);

            //structure type or reference type
            //in this example, the variable point to an address! So if one changes, the other will change too.
            var array1 = new int[3] { 2, 4, 6 };
            var array2 = array1;
            Console.WriteLine(string.Format("array1[0]:{0} array2[0]:{1}", array1[0], array2[0]));
            array2[2] = 300;
            Console.WriteLine(string.Format("array1[0]:{0} array2[0]:{1}", array1[0], array2[0]));
            Console.WriteLine(string.Format("array1[0]:{0}, array1[1]:{1}, array1[2]:{2}", array1[0], array1[1], array1[2]));
        }
    }
}
