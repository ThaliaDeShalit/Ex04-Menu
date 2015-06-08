using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    class MenuItem
    {
        public event Action<MenuItem> clicked;
    }
}
