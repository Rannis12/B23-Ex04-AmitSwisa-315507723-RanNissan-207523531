using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public interface IMenuItemActionObserver
    {
        void Execute();
    }

    public abstract class MenuItem
    {
        private string m_Title;
        private List<IMenuItemActionObserver> m_ItemAction;

        internal string Title
        {
            get
            {
                return m_Title;
            }
            set
            {
                m_Title = value;
            }
        }

        public MenuItem(string i_Title)
        {
            this.Title = i_Title;
        }

        public void AttachMenuItemActionListener(IMenuItemActionObserver i_ItemAction)
        {
            if (this.m_ItemAction == null)
            {
                this.m_ItemAction = new List<IMenuItemActionObserver>();
            }

            this.m_ItemAction.Add(i_ItemAction);
        }

        public void DetachMenuItemActionListener(IMenuItemActionObserver i_ItemAction)
        {
            if (this.m_ItemAction != null)
            {
                this.m_ItemAction.Remove(i_ItemAction);
            }
        }

        public virtual void Execute()
        {
            if (this.m_ItemAction != null)
            {
                int numOfActions = this.m_ItemAction.Count;
                for (int i = 0; i < numOfActions; i++)
                {
                    this.m_ItemAction[i].Execute();
                    Console.WriteLine("");
                }
            }
        }

        public abstract void OnChooseAction();

        public override string ToString()
        {
            return Title;
        }
    }

}
