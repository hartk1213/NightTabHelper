using NightTabHelper.BookmarkClasses.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.Classes.StateClasses.ThemeClasses

{
    public class Theme : State
    {
        #region private
        private Accent accent;
        private string style;
        private decimal radius;
        #endregion

        public Accent Accent
        {
            get { return accent; }
            set { accent = value; }
        }

        public string Style
        {
            get { return style; }
            set { style = value; }
        }
        public decimal Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        #region Properties
        #endregion
        public Theme()
        {
            style = "";
            radius = 0;
        }
    }
}
