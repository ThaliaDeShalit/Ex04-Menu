using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class ShowTime : MenuItem, IClickable
    {
        public ShowTime()
            : base("Show Time")
        {

        }

        public void DoSomething()
        {
            TesterUtils.showTime();
        }
    }

    class ShowDate : MenuItem, IClickable
    {
        public ShowDate()
            : base("Show Date")
        {

        }

        public void DoSomething()
        {
            TesterUtils.showDate();
        }
    }

    class ShowVersion : MenuItem, IClickable
    {
        public ShowVersion()
            : base("Show Version")
        {

        }

        public void DoSomething()
        {
            TesterUtils.showVersion();
        }
    }

    class CountWords : MenuItem, IClickable
    {
        public CountWords()
            : base("Count Words")
        {

        }

        public void DoSomething()
        {
            TesterUtils.countWords();
        }
    }
}
