using System;
using System.Collections.Generic;

namespace StringsDemos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //var fullName = "Ian Aranha ";
            //Console.WriteLine("No Trim: '{0}'", fullName);
            //Console.WriteLine("Trim: '{0}'", fullName.Trim());
            //Console.WriteLine("Trim and ToUpper: '{0}'", fullName.Trim().ToUpper());
            //Console.WriteLine("Trim: and ToLower '{0}'", fullName.Trim().ToLower());


            //var index = fullName.IndexOf(' ');
            //var firstName = fullName.Substring(0, index);
            //var lastName = fullName.Substring(index + 1);
            //Console.WriteLine("First name: " + firstName);
            //Console.WriteLine("Last name: " + lastName);

            //var names = fullName.Split(' ');
            //Console.WriteLine("Split first name: "+ names[0]);
            //Console.WriteLine("Split last name: " + names[1]);

            //var str = "25";
            //Console.WriteLine("No Conversion: "+ str);
            //Console.WriteLine("Conversion to Int32: " + Convert.ToInt32(str));
            //Console.WriteLine("Conversion to Byte: " + Convert.ToByte(str));

            //float price = 20.35f;
            //Console.WriteLine("Price to string: "+ price.ToString("C"));
            //Console.WriteLine("Price: " + price);

            var sentence = "This is going to be a really really really really really really really really really really really really really really long sentence";
            var sentence2 = "Hello World";
            //Console.WriteLine(sentence);
            var summary = SummarizeText(sentence, 20);
            var summary2 = SummarizeText(sentence2, 20);
            Console.WriteLine(summary);
            Console.WriteLine(summary2);

        }

        static string SummarizeText(string text, int maxLength = 25)
        {

            //If the incoming text is already at or below limit, return the text.
            if (text.Length < maxLength)
                return text;


            //First split each word from the text into a new array. Each word == one element.
            var words = text.Split(' ');

            //Now we will count how many characters in each word and when the total exceeds the max lenght allowed in the summary, break out...
            //Establish a counter
            var totalCharacters = 0;

            //Establish an empty list to which words will be added.
            var summaryList = new List<string>();

            //Add each word to the summary list and right after adding, increase the counter
            //Count how many characters in each word and add 1 to account for the space
            foreach (var word in words)
            {
                summaryList.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }

            //create a new string from the summary list and print it
            return String.Join(" ", summaryList) + "....";
        }
    }
}

