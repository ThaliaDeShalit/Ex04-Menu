using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    class TestMenuDelegate
    {
        public TestMenuDelegate()
        {
            createAndRunMainMenu();
        }

        private void createAndRunMainMenu()
        {
            MenuItem mainMenu = new MenuItem("Delegate Main Menu");

            MenuItem showDateTimeMenu = createShowDateTimeMenu();
            MenuItem infoMenu = createInfoMenu();

            mainMenu.SubItems.Add(showDateTimeMenu);
            mainMenu.SubItems.Add(infoMenu);

            MainMenu menu = new MainMenu(mainMenu);

            menu.Show();
        }

        private MenuItem createShowDateTimeMenu()
        {
            MenuItem showDateTimeMenu = new MenuItem("Show Date/Time");

            MenuItem showTime = new MenuItem("Show Time");
            showTime.Selected += new Action<MenuItem>(showTime_Selected);

            MenuItem showDate = new MenuItem("Show Date");
            showDate.Selected += new Action<MenuItem>(showDate_Selected);

            showDateTimeMenu.SubItems.Add(showTime);
            showDateTimeMenu.SubItems.Add(showDate);

            return showDateTimeMenu;
        }

        private MenuItem createInfoMenu()
        {
            MenuItem infoMenu = new MenuItem("Info");

            MenuItem showVersion = new MenuItem("Show Version");
            showVersion.Selected += new Action<MenuItem>(showVersion_Selected);

            MenuItem countWords = new MenuItem("Count Words");
            countWords.Selected += new Action<MenuItem>(countWords_Selected);

            infoMenu.SubItems.Add(showVersion);
            infoMenu.SubItems.Add(countWords);

            return infoMenu;
        }



        private void showTime_Selected(MenuItem i_MenuItem)
        {
            Console.WriteLine("Current time: {0}", DateTime.Now.ToString("h:mm:ss tt"));
        }

        private void showDate_Selected(MenuItem i_MenuItem)
        {
            Console.WriteLine("Current date: {0}", DateTime.Now.ToString("dd/MM/yy"));
        }

        private void showVersion_Selected(MenuItem i_MenuItem)
        {
            Console.WriteLine("Version: 15.2.4.0");
        }

        private void countWords_Selected(MenuItem i_MenuItem)
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
            String text = i_Phrase.Trim();
            int wordCount = 0, index = 0;

            while (index < text.Length)
            {
                // check if current char is part of a word
                while (index < text.Length && Char.IsWhiteSpace(text[index]) == false)
                    index++;

                wordCount++;

                // skip whitespace until next word
                while (index < text.Length && Char.IsWhiteSpace(text[index]) == true)
                    index++;
            }

            return wordCount;
        }
    }
}
