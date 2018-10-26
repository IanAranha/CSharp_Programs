using System;
using System.Collections.Generic;
namespace StringsDemos
{
    public class StringUtility
    {
        public StringUtility()
        {
        }
        public string SummarizeText(string text, int maxLength = 25)
        {
            if (text.Length < maxLength)
                return text;
            //First split each word and the result of this action is a new array with each word as an element
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
            var summary = String.Join(" ", summaryList) + "....";
            return summary;
        }
    }
}
