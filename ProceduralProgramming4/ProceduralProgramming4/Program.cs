using System;

namespace ProceduralProgramming4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Exercise4();
        }

        //Write a program and ask the user to enter a few words separated by a space. 
        //Use the words to create a variable name with PascalCase. 
        //For example, if the user types: "number of students", display "NumberOfStudents".
        //Make sure that the program is not dependent on the input. 
        //So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

        public static void Exercise4()
        {
            Console.WriteLine("Enter a few words separatd by space");
            var input = Console.ReadLine();
            var message = ChangeToPascalCase(input);
            Console.WriteLine(message);

        }

        public static string ChangeToPascalCase(String input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                var message = "Invalid String";
                return message;
            }

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var WordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += WordWithPascalCase;
            }
            return variableName;
        }

    }
}
