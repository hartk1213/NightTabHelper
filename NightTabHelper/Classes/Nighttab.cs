using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NightTabHelper.Classes.BookmarkClasses;
using NightTabHelper.Classes.StateClasses;

namespace NightTabHelper.Classes
{
    public class NightTabClass
    {
        #region Private
        private bool nighttab;
        private string version;
        private State state;
        private List<Bookmark> bookmarks;
        #endregion

        #region Properties
        public bool NightTab
        {
            get
            {
                return nighttab;
            }
            set { nighttab = value; }
        }
        public string Version
        {
            get
            {
                return version;
            }
            set { version = value; }
        }
        public State State
        {
            get
            {
                return state;
            }
            set { state = value; }
        }
        public List<Bookmark> Bookmarks
        {
            get
            {
                return bookmarks;
            }
            set { bookmarks = value; }
        }
        #endregion

        public NightTabClass()
        {
            nighttab = false;
            version = "";
        }

    }
}
