using System;

namespace DateTime
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var fullName = "Ian Aranha  ";
            Console.WriteLine("No Trim: {0}.", fullName);
            Console.WriteLine("Trim: {0}.", fullName.Trim());
            Console.WriteLine("To Upper: {0}.", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            Console.WriteLine("Index: {0}", index);
            var firstName = fullName.Substring(0, index);
            Console.WriteLine("First Name: {0}", firstName);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("Last Name: {0}", lastName);
            var replaced = fullName.Replace('a', 'A');
            Console.WriteLine("Replaced: {0}", replaced);

            var str = "25";
            Console.WriteLine(str);
            var age = Convert.ToInt32(str);
            var age1 = Convert.ToByte(str);
            Console.WriteLine("Int: {0}", age);
            Console.WriteLine("Byte; {0}", age1);

            float price = 5.56f;
            Console.WriteLine("Price: {0}", price.ToString("C"));
            Console.WriteLine("Price: {0}", price.ToString("C0"));

            var name = "Mosh";
            var name2 = name.ToUpper();
            Console.WriteLine(name);
            Console.WriteLine(name2);

            var name3 = " ";
            var result = String.IsNullOrEmpty(name3);
            Console.WriteLine(result);

            var builder = new StringBuilder

        }
    }
}
