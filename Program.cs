using System;
using System.Collections.Generic;

namespace SummarisingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really long text about my a really long text.";
            const int maxLength = 25;

            if (sentence.Length < maxLength)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                var words = sentence.Split(' ');
                var totalCharacters = 0;

                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1; // Adding 1 for the space

                    if (totalCharacters > maxLength)
                        break;
                }

                var summary = string.Join(" ", summaryWords) + "...";
                Console.WriteLine(summary);
            }
        }

       
    }
}
