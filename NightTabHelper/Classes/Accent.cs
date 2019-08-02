using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.Classes
{
    public class Accent
    {
        public Accent()
        {
            color = new Color();
            overRide = "";
        }
        private string overRide = "";
        public Color color;

        public string OverRide
        {
            get
            {
                return overRide;
            }
            set { overRide = value; }
        }
    }
}
