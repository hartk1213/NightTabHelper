using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.BookmarkClasses.Classes
{
    public class Accent
    {
        #region private       
        private string overRide = "";
        private Color color;
        private Color current;
        private Random random;
        #endregion
        #region Properties
        public string OverRide
        {
            get
            {
                return overRide;
            }
            set { overRide = value; }
        }

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
        public Color Current
        {
            get { return current; }
            set { current = value; }
        }
        public Random Random
        {
            get { return random; }
            set { random = value; }
        }
        #endregion
        public Accent()
        {
            overRide = "";
        }
    }

    public class Random : Accent
    {
        private bool active;
        private string style;

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public string Style
        {
            get { return style; }
            set { style = value; }
        }
    }
}
