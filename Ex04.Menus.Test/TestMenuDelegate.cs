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

        // Create and show the main menu
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

        // Creates the Show Time/Date sub menu tree
        private MenuItem createShowDateTimeMenu()
        {
            MenuItem showDateTimeMenu = new MenuItem("Show Date/Time");

            MenuItem showTime = new MenuItem("Show Time");
            showTime.Selected += (showTime_Selected);

            MenuItem showDate = new MenuItem("Show Date");
            showDate.Selected += (showDate_Selected);

            showDateTimeMenu.SubItems.Add(showTime);
            showDateTimeMenu.SubItems.Add(showDate);

            return showDateTimeMenu;
        }

        // Creates the Info sub menu tree
        private MenuItem createInfoMenu()
        {
            MenuItem infoMenu = new MenuItem("Info");

            MenuItem showVersion = new MenuItem("Show Version");
            showVersion.Selected += (showVersion_Selected);

            MenuItem countWords = new MenuItem("Count Words");
            countWords.Selected += (countWords_Selected);

            infoMenu.SubItems.Add(showVersion);
            infoMenu.SubItems.Add(countWords);

            return infoMenu;
        }


        // All the methods that are attached to each of the leaf menu items
        private void showTime_Selected(MenuItem i_MenuItem)
        {
            TesterUtils.showTime();
        }

        private void showDate_Selected(MenuItem i_MenuItem)
        {
            TesterUtils.showDate();
        }

        private void showVersion_Selected(MenuItem i_MenuItem)
        {
            TesterUtils.showVersion();

        }

        private void countWords_Selected(MenuItem i_MenuItem)
        {
            TesterUtils.countWords();
        }
    }
}
