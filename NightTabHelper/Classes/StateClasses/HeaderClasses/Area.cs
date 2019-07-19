using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.Classes.StateClasses.HeaderClasses
{
    public class Area
    {
        #region Private
        private int width;
        private string alignment;
        #endregion

        #region Properties
        public int Width
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
        { }
    }
}
