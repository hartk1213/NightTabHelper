using System;
namespace NightTabHelper
{
    public class Header
    {

        public Header()
        {
            icon = new Icon();
            accent = new Accent();

        }
        private string display = "";
        private string letter = "";
        public Icon icon;
        private string name = "";
        private string url = "";
        private string timeStamp = "";
        public Accent accent;

        public string Letter
        {
            get
            {
                return letter;
            }
            set { letter = value; }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set { name = value; }
        }
        public string Url
        {
            get
            {
                return url;
            }
            set { url = value; }
        }
        public string Timestamp
        {
            get
            {
                return timeStamp;
            }
            set { timeStamp = value; }
        }
        public string Display
        {
            get
            {
                return display;
            }
            set { display = value; }
        }



    }
}
