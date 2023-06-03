using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        private string m_Title;

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

        public abstract void OnChooseAction();

        public override string ToString()
        {
            return Title;
        }
    }

}
