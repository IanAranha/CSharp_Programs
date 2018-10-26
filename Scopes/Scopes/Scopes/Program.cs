using System;

namespace Scopes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //The code below is the declaration and initiation of variables.

            //Each variable is declared as an expression.
            //The left side of the expression is the declaration of type and identification name
            //The right side of the expression is initial value assigned to the variable.
            byte numbers = 5;
            int count = 10;
            float totalPrice = 22.33f;
            char character = 'L';
            string firstName = "Ian";
            string lastName = "Aranha";
            bool isWorking = true;

            //In the above expressions, we could easily replace all the variable types with the keyword var. 
            //C-Sharp will automatically detect the kind.
            var numbers2 = 4;
            var count2 = 20;
            var totalPrice2 = 22.44;
            var character2 = 'C';
            var firstName2 = "Andrew";
            var isWorking2 = false;


            //Now to print out all the variables on the console.
            Console.WriteLine(numbers);
            Console.WriteLine(numbers2);
            Console.WriteLine(count);
            Console.WriteLine(count2);
            Console.WriteLine(totalPrice);
            Console.WriteLine(totalPrice2);
            Console.WriteLine(firstName + " " + character + " " +  lastName);
            Console.WriteLine(firstName2 + " " + character2 +  " " + lastName);
            if (isWorking)
            {
                Console.WriteLine("Working");
            }
            else 
            {
                Console.WriteLine("Not Working.");
            }
            if(isWorking2)
            {
                Console.WriteLine("Hooray!");
            }
            else
            {
                Console.WriteLine("Dammit");
            }

            //The code below should show 0 and 255. Those are the min and max values that can be stored in a byte.
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            //The code below shows the min and max scientific notations that can be stored in a variable.
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

        }
    }
}
