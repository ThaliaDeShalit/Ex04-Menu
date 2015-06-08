using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    class MenuItem
    {
        public event Action<MenuItem> clicked;

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

        internal bool IsSubMenu()
        {
            bool isSubMenu = true;

            if (m_SubItems.Count == 0)
            {
                isSubMenu = false;
            }

            return isSubMenu;
        }

        public void onClicked()
        {
            if (clicked != null)
            {
                clicked(this);
            }
        }
    }
}
