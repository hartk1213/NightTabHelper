using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.BookmarkClasses.Classes
{
    public class Color
    {
        #region private
        private string r = "0";
        private string g = "0";
        private string b = "0";
        #endregion
        #region Properties
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
        #endregion
        public Color()
        {
            r = "41";
            g = "119";
            b = "244";
        }
    }
}
