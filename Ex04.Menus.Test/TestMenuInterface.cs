using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class TestMenuInterface
    {
        private MainMenu m_Menu;

        public TestMenuInterface()
        {
            createMainMenu();
        }

        public void Run()
        {
            m_Menu.Show();
        }

        // Create and show the main menu
        private void createMainMenu()
        {
            MenuItem mainMenu = new MenuItem("Interface Main Menu");

            MenuItem showDateTimeMenu = createShowDateTimeMenu();
            MenuItem infoMenu = createInfoMenu();

            mainMenu.SubItems.Add(showDateTimeMenu);
            mainMenu.SubItems.Add(infoMenu);

            m_Menu = new MainMenu(mainMenu);
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
        private class ShowTime : MenuItem, IActionable
        {
            public ShowTime()
                : base("Show Time")
            {

            }

            public void DoSomething()
            {
                TesterUtils.ShowTime();
            }
        }

        private class ShowDate : MenuItem, IActionable
        {
            public ShowDate()
                : base("Show Date")
            {

            }

            public void DoSomething()
            {
                TesterUtils.ShowDate();
            }
        }

        private class ShowVersion : MenuItem, IActionable
        {
            public ShowVersion()
                : base("Show Version")
            {

            }

            public void DoSomething()
            {
                TesterUtils.ShowVersion();
            }
        }

        private class CountWords : MenuItem, IActionable
        {
            public CountWords()
                : base("Count Words")
            {

            }

            public void DoSomething()
            {
                TesterUtils.CountWords();
            }
        }
    }
}
