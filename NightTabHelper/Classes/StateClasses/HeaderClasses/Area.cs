using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.Classes.StateClasses.HeaderClasses
{
    public class Area : Header
    {
        #region Private
        private int width;
        #endregion

        #region Properties
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        #endregion
        public Area()
        {
            width = 0;
        }
    }
}
