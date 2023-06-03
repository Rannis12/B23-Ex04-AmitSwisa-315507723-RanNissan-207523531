using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class MenuOptions
    {
        public class ShowDate : IMenuItemActionObserver
        {
            public void Execute()
            {
                ExerciseFunctions.ShowDate();
            }
        }

        public class ShowTime : IMenuItemActionObserver
        {
            public void Execute()
            {
                ExerciseFunctions.ShowTime();
            }
        }

        public class ShowVersion : IMenuItemActionObserver
        {
            public void Execute()
            {
                ExerciseFunctions.ShowVersion();
            }
        }

        public class SpacesCount : IMenuItemActionObserver
        {
            public void Execute()
            {
                ExerciseFunctions.CountSpaces();
            }
        }
    }
}
