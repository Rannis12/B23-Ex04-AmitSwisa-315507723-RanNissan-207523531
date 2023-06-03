using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ShowInterfaceMenu();
            ShowDelegatesMenu();
        }

        public static void ShowInterfaceMenu()
        {
            Interfaces.MainMenu mainMenu = new Interfaces.MainMenu("Interface Menu");

            // Versions And Spaces - Menu
            Interfaces.Menu versionsAndSpacesMenu = new Interfaces.Menu("Versions and Spaces");

            Interfaces.MenuAction versionOption = new Interfaces.MenuAction("Show Version");
            versionOption.AttachMenuItemActionListener(new MenuOptions.ShowVersion());

            Interfaces.MenuAction spacesOption = new Interfaces.MenuAction("Count Spaces");
            spacesOption.AttachMenuItemActionListener(new MenuOptions.SpacesCount());

            versionsAndSpacesMenu.AddMenuItem(versionOption);
            versionsAndSpacesMenu.AddMenuItem(spacesOption);
            // END

            // Show Date/Time
            Interfaces.Menu dateAndTimeMenu = new Interfaces.Menu("Show Date/Time");

            Interfaces.MenuAction showDateOption = new Interfaces.MenuAction("Show Date");
            showDateOption.AttachMenuItemActionListener(new MenuOptions.ShowDate());

            Interfaces.MenuAction showTimeOption = new Interfaces.MenuAction("Show Time");
            showTimeOption.AttachMenuItemActionListener(new MenuOptions.ShowTime());

            dateAndTimeMenu.AddMenuItem(showDateOption);
            dateAndTimeMenu.AddMenuItem(showTimeOption);
            // END

            mainMenu.AddMenuItem(dateAndTimeMenu);
            mainMenu.AddMenuItem(versionsAndSpacesMenu);

            mainMenu.Show();
        }

        public static void ShowDelegatesMenu()
        {
            Delegates.MainMenu mainMenu = new Delegates.MainMenu("Delegates Menu");

            // Versions And Spaces - Menu
            Delegates.Menu versionsAndSpacesMenu = new Delegates.Menu("Versions and Spaces");

            Delegates.MenuAction versionOption = new Delegates.MenuAction("Show Version");
            versionOption.AttachMenuItemActionListener(ExerciseFunctions.ShowVersion);

            Delegates.MenuAction spacesOption = new Delegates.MenuAction("Count Spaces");
            spacesOption.AttachMenuItemActionListener(ExerciseFunctions.CountSpaces);

            versionsAndSpacesMenu.AddMenuItem(versionOption);
            versionsAndSpacesMenu.AddMenuItem(spacesOption);
            // END

            // Show Date/Time
            Delegates.Menu dateAndTimeMenu = new Delegates.Menu("Show Date/Time");

            Delegates.MenuAction showDateOption = new Delegates.MenuAction("Show Date");
            showDateOption.AttachMenuItemActionListener(ExerciseFunctions.ShowDate);

            Delegates.MenuAction showTimeOption = new Delegates.MenuAction("Show Time");
            showTimeOption.AttachMenuItemActionListener(ExerciseFunctions.ShowTime);

            dateAndTimeMenu.AddMenuItem(showDateOption);
            dateAndTimeMenu.AddMenuItem(showTimeOption);
            // END

            mainMenu.AddMenuItem(dateAndTimeMenu);
            mainMenu.AddMenuItem(versionsAndSpacesMenu);

            mainMenu.Show();
        }
    }
}
