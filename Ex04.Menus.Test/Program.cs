using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            TestMenuInterface interfaceTest = new TestMenuInterface();
            interfaceTest.Run();

            TestMenuDelegate delegateTest = new TestMenuDelegate();
            delegateTest.Run();
        }       
    }
}
