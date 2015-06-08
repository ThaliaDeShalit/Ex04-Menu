using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private const string k_HeaderSeperator = "---";
        private const string k_ExitOption = "0: Exit";
        private const string k_BackOption = "0: Back";
        private const string k_ChooseRequest = "Please choose a number corresponding to one of the aformentioned options";
        private const string k_GoodbyeMessage = "Goodbye. Press any key to leave...";
        private const string k_InvalidInputOutOfBounds = "Invalid input: input must be between 0 and {0}, please enter a valid input:"; // the max value is entered by the relevent method
        private const string k_InvalidInputNotADigit = "Invalid input: input must be a digit, please enter a valid input:";
        private const string k_PressToContinue = "Press any key to continue";
        private const int k_ExitOrBackNumRepresntation = 0;

        private MenuItem m_MainMenu;

        public MainMenu(MenuItem i_MainMenu)
        {
            m_MainMenu = i_MainMenu;
        }

        // The method that calls a recursive method that generates the menus
        public void Show()
        {
            showMenu(m_MainMenu, k_ExitOption);
            Console.Clear();
            Console.WriteLine(k_GoodbyeMessage);
            Console.ReadKey();
        }

        // A recursive method that generates the menus (first the main, then the subs).
        // The method recives the relevent '0' option string to make sure no irrelevant
        // if's are called
        private void showMenu(MenuItem i_Menu, string i_BackOrExitOption)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int inputFromUser;
            int index;

            while (true)
            {
                // Reseting the screen, index and stringBuilder
                Console.Clear();
                index = 1;
                stringBuilder.Length = 0;

                // Appending the header and the '0' option
                stringBuilder.Append(string.Format(
@"{0}
{1}
{2}
", i_Menu.Header, k_HeaderSeperator, i_BackOrExitOption));

                // Appending the headers of all the menu items in the current menu
                foreach (MenuItem menuItem in i_Menu.SubItems)
                {
                    stringBuilder.Append(string.Format(
@"{0}: {1} 
", index, menuItem.Header));
                    index++;
                }

                Console.WriteLine(stringBuilder.ToString());

                // Getting the input from the user
                inputFromUser = getInput(i_Menu.SubItems.Count);
                
                Console.Clear();

                // first checking the user chose the '0' option, and if so breaking the 
                // loop and going one step back in the recursion
                if (inputFromUser == k_ExitOrBackNumRepresntation)
                {
                    break;
                }
                else
                {
                    MenuItem subItem = i_Menu.SubItems[inputFromUser - 1];

                    // Checking if the item selected is a sub menu or a method caller
                    if (subItem.IsSubMenu())
                    {
                        showMenu(subItem, k_BackOption);
                    }
                    else
                    {
                        // Runs the method that was overrided by the user
                        (subItem as IActionable).DoSomething();

                        Console.WriteLine("{0}{1}", Environment.NewLine, k_PressToContinue);
                        Console.ReadKey();
                    }
                }
            }
        }

        // This method gets the input and makes sure it is valid
        private int getInput(int i_MaxIntValue)
        {
            int intInputFromUser;
            string inputFromUser;

            Console.WriteLine(k_ChooseRequest);
            while (true)
            {
                inputFromUser = Console.ReadLine();

                // Tries to parse to int
                if (int.TryParse(inputFromUser, out intInputFromUser))
                {
                    // Checks if the int entered is out of bounds
                    if (intInputFromUser > i_MaxIntValue || intInputFromUser < 0)
                    {
                        Console.WriteLine(string.Format(k_InvalidInputOutOfBounds, i_MaxIntValue));
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine(k_InvalidInputNotADigit);
                }
            }

            return intInputFromUser;
        }
    }
}
