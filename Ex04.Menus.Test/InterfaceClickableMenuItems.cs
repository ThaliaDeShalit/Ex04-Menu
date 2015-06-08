using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class ShowTime : MenuItem, IClickable
    {
        public ShowTime()
            : base("Show Time")
        {

        }

        public void DoSomething()
        {
            Console.WriteLine("Current time: {0}", DateTime.Now.ToString("h:mm:ss tt"));
        }
    }

    class ShowDate : MenuItem, IClickable
    {
        public ShowDate()
            : base("Show Date")
        {

        }

        public void DoSomething()
        {
            Console.WriteLine("Current date: {0}", DateTime.Now.ToString("DD/MM/YYYY"));
        }
    }

    class ShowVersion : MenuItem, IClickable
    {
        public ShowVersion()
            : base("Show Version")
        {

        }

        public void DoSomething()
        {
            Console.WriteLine("Version: 15.2.4.0");
        }
    }

    class CountWords : MenuItem, IClickable
    {
        public CountWords()
            : base("Count Words")
        {

        }

        public void DoSomething()
        {
            int numOfWords;
            string input;

            Console.WriteLine("Please enter a phrase:");
            input = Console.ReadLine();
            numOfWords = countWords(input);
            Console.WriteLine("There are {0} words in the phrase '{1}'", numOfWords.ToString(), input);
        }

        private int countWords(string i_Phrase)
        {
            int numOfWords = 0;

            foreach (char character in i_Phrase)
            {
                if (character == ' ')
                {
                    numOfWords++;
                }
            }

            return numOfWords;
        }
    }
}
