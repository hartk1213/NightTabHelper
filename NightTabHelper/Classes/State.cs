using NightTabHelper.Classes.StateClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.Classes
{
    public class State
    {
        #region Private
        private Header header;
        private Link link;
        private Layout layout;
        private Theme theme;
        private Background background;
        private bool edge;
        private bool search;
        private bool menu;
        private bool modal;
        private bool autoSuggest;
        #endregion

        #region Properties

        public Header Header
        {
            get
            {
                return header;
            }
            set { header = value; }
        }
        public Link Link
        {
            get
            {
                return link;
            }
            set { link = value; }
        }
        public Layout Layout
        {
            get
            {
                return layout;
            }
            set { layout = value; }
        }
        public Theme Theme
        {
            get
            {
                return theme;
            }
            set { theme = value; }
        }
        public Background Background 
        {
            get
            {
                return background;
            }
            set { background = value; }
        }

        #endregion

        public State() { }

    }
}
