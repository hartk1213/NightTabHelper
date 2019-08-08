using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.Classes.StateClasses.LayoutClasses

{
    public class Layout : State
    {
        #region private
        private string alignment;
        private string order;
        private decimal padding;
        private decimal gutter;
        private decimal width;
        private bool scrollPastEnd;
        private string title;
        #endregion
        #region Properties
        public string Alignment
        {
            get { return alignment; }
            set { alignment = value; }
        }

        public string Order
        {
            get { return order; }
            set { order = value; }
        }
        public decimal Padding
        {
            get { return padding; }
            set { padding = value; }
        }
        public decimal Gutter
        {
            get { return gutter; }
            set { gutter = value; }
        }
        public decimal Width
        {
            get { return width; }
            set { width = value; }
        }
        public bool ScrollPastEnd
        {
            get { return scrollPastEnd; }
            set { scrollPastEnd = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        #endregion
        public Layout() {
            alignment = "";
            order = "";
            padding = 0;
            gutter = 0;
            width = 0;
            scrollPastEnd = false;
            title = "";
        }
    }
}
