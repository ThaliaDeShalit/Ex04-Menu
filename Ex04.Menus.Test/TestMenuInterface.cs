using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class TestMenuInterface
    {
        public TestMenuInterface()
        {
            createAndRunMainMenu();
        }

        // Create and show the main menu
        private void createAndRunMainMenu()
        {
            MenuItem mainMenu = new MenuItem("Interface Main Menu");

            MenuItem showDateTimeMenu = createShowDateTimeMenu();
            MenuItem infoMenu = createInfoMenu();

            mainMenu.SubItems.Add(showDateTimeMenu);
            mainMenu.SubItems.Add(infoMenu);

            MainMenu menu = new MainMenu(mainMenu);

            menu.Show();
        }

        // Creates the Show Time/Date sub menu tree
        private MenuItem createShowDateTimeMenu()
        {
            MenuItem showDateTimeMenu = new MenuItem("Show Date/Time");
            
            ShowTime showTime = new ShowTime();
            ShowDate showDate = new ShowDate();

            showDateTimeMenu.SubItems.Add(showTime);
            showDateTimeMenu.SubItems.Add(showDate);

            return showDateTimeMenu;
        }

        // Creates the Info sub menu tree
        private MenuItem createInfoMenu()
        {
            MenuItem infoMenu = new MenuItem("Info");

            ShowVersion showVersion = new ShowVersion();
            CountWords countWords = new CountWords();

            infoMenu.SubItems.Add(showVersion);
            infoMenu.SubItems.Add(countWords);

            return infoMenu;
        }

        // Each class underneath represents a different type of menu item
        internal class ShowTime : MenuItem, IActionable
        {
            public ShowTime()
                : base("Show Time")
            {

            }

            public void DoSomething()
            {
                TesterUtils.showTime();
            }
        }

        internal class ShowDate : MenuItem, IActionable
        {
            public ShowDate()
                : base("Show Date")
            {

            }

            public void DoSomething()
            {
                TesterUtils.showDate();
            }
        }

        internal class ShowVersion : MenuItem, IActionable
        {
            public ShowVersion()
                : base("Show Version")
            {

            }

            public void DoSomething()
            {
                TesterUtils.showVersion();
            }
        }

        internal class CountWords : MenuItem, IActionable
        {
            public CountWords()
                : base("Count Words")
            {

            }

            public void DoSomething()
            {
                TesterUtils.countWords();
            }
        }
    }
}
