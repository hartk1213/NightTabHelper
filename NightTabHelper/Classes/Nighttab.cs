using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NightTabHelper.Classes.StateClasses;

namespace NightTabHelper.Classes
{
    public class NightTabClass
    {
        #region Private
        private bool nighttab = false;
        private string version = "";
        private State state;
        private Header header;
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
        public Header Header
        {
            get
            {
                return header;
            }
            set { header = value; }
        }
        #endregion

        public NightTabClass()
        {
            state = new State();
            header = new Header();

        }

    }
}
