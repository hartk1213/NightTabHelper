using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.Classes.StateClasses.LinkClasses
{
    public class Item : Link
    {
        #region private
        private decimal size;
        private string alignment;
        private Display display;
        private Name name;
        private Url url;
        private Line line;
        private HoverScale hoverscale;
        private string order;
        #endregion
        #region Properties
        public decimal Size {
            get { return size; }
            set { size = value; }
        }

        public string Alignment {
            get { return alignment; }
            set { alignment = value; }
        }
        public Display Display
        {
            get { return display; }
            set { display = value; }

        }
        public Name Name
        {
            get { return name; }
            set { name = value; }
        }
        public Url Url
        {
            get { return url; }
            set { url = value; }
        }
        public Line Line
        {
            get { return line; }
            set { line = value; }
        }
        public HoverScale HoverScale
        {
            get { return hoverscale; }
            set { hoverscale = value; }
        }
        public string Order
        {
            get { return order; }
            set { order = value; }
        }
        #endregion
        public Item()
        {
            size = 0;
            alignment = "";
        }
        
    }
    #region subclasses
    public class Display : Item
    {
        private Letter letter;
        private Icon icon;
        public Letter Letter
        {
            get { return letter; }
            set { letter = value; }
        }
        public Icon Icon
        {
            get { return icon; }
            set { icon = value; }
        }
    }
    public class Letter : Display
    {
        public Letter() { }
    }
    public class Icon : Display
    {
        public Icon() { }
    }
    public class Name : Item
    {
        public Name() { }
    }
    public class Url : Item
    {
        public Url() { }
    }
    public class Line : Item
    {
        public Line() { }
    }
    public class HoverScale : Item
    {
        public HoverScale() { }
    }

    #endregion

}
