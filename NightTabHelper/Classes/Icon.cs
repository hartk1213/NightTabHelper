using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.Classes
{
    public class Icon
    {
        public Icon()
        {
            name = "";
            prefix = "";
            label = "";
        }
        private string name = "";
        private string prefix = "";
        private string label = "";
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
    }
}
