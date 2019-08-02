using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.Classes
{
    public class Color
    {
        public Color()
        {
            r = "41";
            g = "119";
            b = "244";
        }
        private string r = "0";
        private string g = "0";
        private string b = "0";

        public string R
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }

        public string G
        {
            get
            {
                return g;
            }
            set
            {
                g = value;
            }
        }

        public string B
        {
            get
            {
                return b;
            }
            set { b = value; }
        }
    }
}
