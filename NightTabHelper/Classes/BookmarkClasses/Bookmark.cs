using NightTabHelper.BookmarkClasses.Classes;
using System;
namespace NightTabHelper.Classes.BookmarkClasses
{
    public class Bookmark
    {
        #region Private
        private string display = "";
        private string letter = "";
        private Icon icon;
        private string name = "";
        private string url = "";
        private Accent accent;
        private string timeStamp = "";
        #endregion

        #region Properties
        public string Display
        {
            get
            {
                return display;
            }
            set { display = value; }
        }
        public string Letter
        {
            get
            {
                return letter;
            }
            set { letter = value; }
        }
        public Icon Icon
        {
            get
            {
                return icon;
            }
            set { icon = value; }
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
        public Accent Accent
        {
            get
            {
                return accent;
            }
            set { accent = value; }
        }
        public string Timestamp
        {
            get
            {
                return timeStamp;
            }
            set { timeStamp = value; }
        }
        #endregion

        public Bookmark()
        {
            display = "";
            letter = "";
            name = "";
            url = "";
            timeStamp = "";
        }
    }
}
