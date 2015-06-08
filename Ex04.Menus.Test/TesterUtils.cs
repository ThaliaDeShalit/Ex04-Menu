using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    // A static class to hold all the menu options. We use it because both the interface
    // and the delegate menu both call the same functions.
    internal static class TesterUtils
    {
        internal static void showTime()
        {
            Console.WriteLine("Current time: {0}", DateTime.Now.ToString("h:mm:ss tt"));
        }

        internal static void showDate()
        {
            Console.WriteLine("Current date: {0}", DateTime.Now.ToString("dd/MM/yy"));
        }

        internal static void showVersion()
        {
            Console.WriteLine("Version: 15.2.4.0");
        }

        internal static void countWords()
        {
            int numOfWords;
            string input;

            Console.WriteLine("Please enter a phrase:");
            input = Console.ReadLine();
            numOfWords = countWords(input);
            Console.WriteLine("There are {0} words in the phrase '{1}'", numOfWords.ToString(), input);
        }

        private static int countWords(string i_Phrase)
        {
            int wordCount = 0;
            int index = 0;

            // Trims the spaces at the begining and end of the string
            i_Phrase = i_Phrase.Trim();

            while (index < i_Phrase.Length)
            {
                // Check if current char is part of a word
                while (index < i_Phrase.Length && char.IsWhiteSpace(i_Phrase[index]) == false)
                {
                    index++;
                }

                wordCount++;

                // Skip whitespace until next word
                while (index < i_Phrase.Length && char.IsWhiteSpace(i_Phrase[index]) == true)
                {
                    index++;
                }
            }

            return wordCount;
        }
    }
}
