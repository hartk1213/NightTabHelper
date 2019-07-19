using System;

namespace NightTabHelper.Classes
{
    public class Icon
    {
        public Icon()
        {

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
