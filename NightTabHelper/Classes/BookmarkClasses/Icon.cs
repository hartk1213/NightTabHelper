using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.BookmarkClasses.Classes
{
    public class Icon
    {
        #region private
        private string name = "";
        private string prefix = "";
        private string label = "";
        #endregion
        #region Properties
        public string Name
        {
            get
            {
                return name;
            }
            set { name = value; }
        }
        public string Prefix
        {
            get
            {
                return prefix;
            }
            set { prefix = value; }
        }
        public string Label
        {
            get
            {
                return label;
            }
            set { label = value; }
        }
        #endregion
        public Icon()
        {
            name = "";
            prefix = "";
            label = "";
        }
    }
}
