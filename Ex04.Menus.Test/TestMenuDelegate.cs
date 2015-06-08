using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    class TestMenuDelegate
    {
        public void run()
        {
            MenuItem file = new MenuItem("File");
            MenuItem newProject = new MenuItem("New Project");
            newProject.Selected += new Action<MenuItem>(newProject_Selected);
            file.SubItems.Add(newProject);


            MainMenu menu = new MainMenu(file);
            menu.Show();
        }

        void newProject_Selected(MenuItem menuItem)
        {
            Console.WriteLine("~~~~~~~~ STARTING NEW PROJECT ~~~~~~~~");
        }      
    }
}
