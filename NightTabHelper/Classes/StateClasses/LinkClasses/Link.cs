using NightTabHelper.Classes.StateClasses.LayoutClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.Classes.StateClasses.LinkClasses

{
    public class Link
    {
        #region private
        private Area area;
        private Item item;
        private bool show;
        private bool edit;
        private string style;
        private bool newTab;

        #endregion

        #region Properties
        public bool Show
        {
            get { return show; }
            set { show = value; }
        }
        public bool Edit
        {
            get { return edit; }
            set { edit = value; }
        }
        public string Style
        {
            get { return style; }
            set { style = value; }
        }
        public bool NewTab
        {
            get { return newTab; }
            set { newTab = value; }
        }
        public Item Item {
            get { return item; }
            set { item = value; }
        }
        public Area Area
        {
            get { return area; }
            set { area = value; }
        }
       

        #endregion

        public Link() {
            show = false;
            edit = false;
            style = "";
            newTab = false;
        }
    }
    #region subclasses

    public class Area : Link
    {
        #region Private
        private decimal width;
        private string alignment;
        #endregion

        #region Properties
        public decimal Width
        {
            get { return width; }
            set { width = value; }
        }
        public string Alignment
        {
            get { return alignment; }
            set { alignment = value; }
        }
        #endregion
        public Area()
        {
            width = 0;
            alignment = "";
        }
    }
   
    

#endregion
}
