using System;

namespace Classes

{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("Hello, let me introduce myself as " + firstName + " " + lastName);
        }
    }
}
