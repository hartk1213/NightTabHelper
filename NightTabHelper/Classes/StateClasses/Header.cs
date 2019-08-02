using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.Classes.StateClasses
{
    public class Header
    {
        private bool show;
        private string display;
        private string alignment;
        public string Alignment
        {
            get { return alignment; }
            set { alignment = value; }
        }
        public bool Show
        {
            get { return show; }
            set { show = value; }
        }
        public string Display
        {
            get { return display; }
            set { display = value; }
        }
    }

    
}
