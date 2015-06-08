using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class Program
    {
        public static void Main()
        {
            MenuItem file = new MenuItem("File");
            NewProjectFunction newProject = new NewProjectFunction("New Project");
            MenuItem add = new MenuItem("Add");
            add.SubItems.Add(newProject);

            file.SubItems.Add(newProject);
            file.SubItems.Add(add);

            MainMenu main = new MainMenu(file);
            main.Show();
        }       

        class NewProjectFunction : MenuItem, IClickable
        {
            public NewProjectFunction(String i_Header)
                : base(i_Header)
            {

            }

            void IClickable.DoSomething()
            {
                startNewProject();
            }

            public void startNewProject()
            {
                Console.WriteLine("~~~~~~ STARTING NEW PROJECT ~~~~~~");
                Console.ReadLine();
            }
        }
    }
}
