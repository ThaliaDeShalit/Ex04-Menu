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
        private const int k_ExitOrBackNumRepresntation = 0;

        private MenuItem m_MainMenu;

        public MainMenu(MenuItem i_MainMenu)
        {
            m_MainMenu = i_MainMenu;
        }

        public void Show()
        {
            showMenu(m_MainMenu, k_ExitOption);
            Console.Clear();
            Console.WriteLine(k_GoodbyeMessage);
            //Console.ReadLine();
            Console.ReadKey();
        }

        private void showMenu(MenuItem i_Menu, string i_BackOrExitOption)
        {

            StringBuilder stringBuilder = new StringBuilder();
            int inputFromUser;
            int index;

            while (true)
            {
                Console.Clear();
                index = 1;
                stringBuilder.Length = 0;
                stringBuilder.Append(string.Format(
@"{0}
{1}
{2}
", i_Menu.Header, k_HeaderSeperator, i_BackOrExitOption));

                foreach (MenuItem menuItem in i_Menu.SubItems)
                {
                    stringBuilder.Append(string.Format(
@"{0}: {1} 
", index, menuItem.Header));
                    index++;
                }

                Console.WriteLine(stringBuilder.ToString());
                inputFromUser = getInput(i_Menu.SubItems.Count);
                Console.Clear();
                if (inputFromUser == k_ExitOrBackNumRepresntation)
                {
                    break;
                }
                else
                {
                    MenuItem subItem = i_Menu.SubItems[inputFromUser - 1];

                    if (subItem.IsSubMenu())
                    {
                        showMenu(subItem, k_BackOption);
                    }
                    else
                    {
                        (subItem as IClickable).DoSomething();
<<<<<<< HEAD
=======

                        Console.WriteLine("{0}{1}", Environment.NewLine, k_PressToContinue);
                        Console.ReadKey();
>>>>>>> origin/master
                    }
                }
            }
        }

        private int getInput(int i_MaxIntValue)
        {
            int intInputFromUser;
            string inputFromUser;

            Console.WriteLine(k_ChooseRequest);
            while (true)
            {
                inputFromUser = Console.ReadLine();

                if (int.TryParse(inputFromUser, out intInputFromUser))
                {
                    if (intInputFromUser > i_MaxIntValue)
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
