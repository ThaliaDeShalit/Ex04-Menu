using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class ShowTime : MenuItem, IActionable
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

    class ShowDate : MenuItem, IActionable
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

    class ShowVersion : MenuItem, IActionable
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

    class CountWords : MenuItem, IActionable
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
