﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        private List<MenuItem> m_SubItems;
        private string m_Header;

        public MenuItem(string i_Header)
        {
            m_SubItems = new List<MenuItem>();
            m_Header = i_Header;
        }

        public List<MenuItem> SubItems
        {
            get
            {
                return m_SubItems;
            }
        }

        public string Header
        {
            get
            {
                return m_Header;
            }
        }

        // Checks if the menu has sub items, and therefor a menu or not
        internal bool IsSubMenu()
        {
            bool isSubMenu = true;

            if (m_SubItems.Count == 0)
            {
                isSubMenu = false;
            }

            return isSubMenu;
        }
    }
}
