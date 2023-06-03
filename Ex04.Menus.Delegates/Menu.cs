using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class Menu : MenuItem
    {
        private readonly List<MenuItem> r_MenuItems = new List<MenuItem>();
        private bool m_ExitMenuDisplay;

        protected List<MenuItem> MenuItems
        {
            get
            {
                return r_MenuItems;
            }
        }

        public Menu(string i_MenuTitle) : base(i_MenuTitle)
        {
            MenuAction backOption = new MenuAction("Back");
            backOption.AttachMenuItemActionListener(this.onExitEvent);
            AddMenuItem(backOption);
        }

        public void Show()
        {
            Console.WriteLine("");
            this.m_ExitMenuDisplay = false;

            while (!m_ExitMenuDisplay)
            {
                printMenu();

                int menuChoice = readInputFromUser();

                MenuItems[menuChoice].OnChooseAction();
            }
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            this.r_MenuItems.Add(i_MenuItem);
        }

        private void printMenu()
        {
            Console.WriteLine(base.Title);

            printTextDivider();

            int numOfMenuItems = this.getNumOfMenuItems();
            for (int i = 1; i < numOfMenuItems; i++)
            {
                Console.WriteLine(i + ". " + this.r_MenuItems[i]);
            }

            Console.WriteLine("0. " + this.r_MenuItems[0]);

            printTextDivider();
        }

        private int getNumOfMenuItems()
        {
            return r_MenuItems.Count;
        }

        private static void printTextDivider()
        {
            Console.WriteLine("###################################");
        }

        protected void ReplaceBackOptionWithExit()
        {
            this.r_MenuItems[0].Title = "Exit";
        }

        private void onExitEvent()
        {
            this.m_ExitMenuDisplay = true;
        }

        public override void OnChooseAction()
        {
            this.Show();
        }

        private int readInputFromUser()
        {
            bool isValidInput = false;
            int integerInput;

            do
            {
                string userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out integerInput)
                        || (integerInput < 0 || integerInput > getNumOfMenuItems() - 1))
                {
                    Console.WriteLine("Please enter a valid option.");
                }
                else
                {
                    isValidInput = true;
                }
            }
            while (!isValidInput);

            return integerInput;
        }
    }
}
