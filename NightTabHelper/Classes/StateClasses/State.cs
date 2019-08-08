using NightTabHelper.Classes.StateClasses.ThemeClasses;
using NightTabHelper.Classes.StateClasses.LinkClasses;
using NightTabHelper.Classes.StateClasses.LayoutClasses;
using NightTabHelper.Classes.BookmarkClasses;
using NightTabHelper.Classes.StateClasses.BackgroundClasses;
using NightTabHelper.Classes.StateClasses.HeaderClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.Classes.StateClasses
{
    public class State : NightTabClass
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

        public bool Edge
        {
            get { return edge; }
            set { edge = value; }
        }
        public bool Search
        {
            get { return search; }
            set { search = value; }
        }
        public bool Menu
        {
            get { return menu; }
            set { menu = value; }
        }
        public bool Modal
        {
            get { return modal; }
            set { modal = value; }
        }
        public bool AutoSuggest
        {
            get { return autoSuggest; }
            set { autoSuggest = value; }
        }

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

        public State() {
            edge = false;
            search = false;
            menu = false;
            modal = false;
            autoSuggest = false;
        }

    }
}
