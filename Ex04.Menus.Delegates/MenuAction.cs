using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MenuAction : MenuItem
    {
        private event Action m_ItemActions;

        public MenuAction(string i_Title) : base(i_Title)
        {

        }

        public void AttachMenuItemActionListener(Action i_ItemAction)
        {
            this.m_ItemActions += i_ItemAction;
        }

        public void DetachMenuItemActionListener(Action i_ItemAction)
        {
            this.m_ItemActions -= i_ItemAction;
        }

        public override void OnChooseAction()
        {
            this.m_ItemActions.Invoke();
            Console.WriteLine("");
        }
    }
}
