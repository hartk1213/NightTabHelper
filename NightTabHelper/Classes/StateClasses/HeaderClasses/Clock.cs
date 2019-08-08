using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.Classes.StateClasses.HeaderClasses
{
    public class Clock : Header
    {
        #region Private

        private Hours hours;
        private Minutes minutes;
        private Seconds seconds;
        private Separator separator;
        private Meridiem meridiem;
        private Hour24 hour24;
        #endregion
        #region Properties
        public Hours Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        public Minutes Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }
        public Seconds Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }
        public Separator Separator
        {
            get { return separator; }
            set { separator = value; }
        }
        public Meridiem Meridiem
        {
            get { return meridiem; }
            set { meridiem = value; }
        }
        public Hour24 Hour24
        {
            get { return hour24; }
            set { hour24 = value; }
        }
        #endregion
        public Clock() {
        }
    }

    #region Sub-Classes
    public class Hours : Clock
    {
        public Hours()
        { }
    }

    public class Minutes : Clock
    {
        public Minutes()
        { }
    }

    public class Seconds : Clock
    {
        public Seconds()
        { }
    }

    public class Meridiem : Clock
    {
        public Meridiem()
        { }
    }

    public class Hour24 : Clock
    {
        public Hour24()
        { }
    }
    #endregion
}
