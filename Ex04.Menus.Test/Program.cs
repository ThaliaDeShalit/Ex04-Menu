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
            TestMenuInterface interfaceTest = new TestMenuInterface();
            TestMenuDelegate delegateTest = new TestMenuDelegate();
        }       
    }
}
