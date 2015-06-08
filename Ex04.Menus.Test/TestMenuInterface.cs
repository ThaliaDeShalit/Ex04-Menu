using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class TestMenuInterface
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
    }
}
