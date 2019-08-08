using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.Classes.StateClasses.HeaderClasses
{
    public class Header : State
    {
        #region Private
        private bool show;
        private string display;
        private bool ordinal;
        private string alignment;
        private string type;
        private string name;
        private decimal size;
        private Area area;
        private Item item;
        private Clock clock;
        private Date date;
        private Search search;
        private Button button;
        private Shade shade;
        private Border border;
        private Greeting greeting;
        private Transitional transitional;
        private bool radius;
        #endregion 
        #region Properties

        public string Type {
            get { return type; } set { type = value; } }
        public string Name {
            get { return name; } set { name = value; } }
        public decimal Size {
            get { return size; } set { size = value; } }
        public string Alignment
        {
            get { return alignment; }
            set { alignment = value; }
        }
        public bool Show
        {
            get { return show; }
            set { show = value; }
        }
        public string Display
        {
            get { return display; }
            set { display = value; }
        }
        public bool Ordinal
        {
            get { return ordinal; }
            set { ordinal = value; }
        }
        public Area Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }
        public Item Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
            }
        }
        public Clock Clock
        {
            get
            {
                return clock;
            }
            set
            {
                clock = value;
            }
        }
        public Date Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public new Search Search
        {
            get
            {
                return search;
            }
            set
            {
                search = value;
            }
        }
        public Button Button
        {
            get
            {
                return button;
            }
            set
            {
                button = value;
            }
        }
        public Shade Shade
        {
            get
            {
                return shade;
            }
            set
            {
                shade = value;
            }
        }
        public Border Border
        {
            get
            {
                return border;
            }
            set
            {
                border = value;
            }
        }
        public Greeting Greeting
        {
            get
            {
                return greeting;
            }
            set
            {
                greeting = value;
            }
        }
        public Transitional Transitional
        {
            get
            {
                return transitional;
            }
            set
            {
                transitional = value;
            }
        }
        public bool Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        #endregion 
        public Header()
        {
            show = false;
            display = "";
            ordinal = false;
            alignment = "";
            radius = false;
        }

    }

    #region SubClasses
    public class Date : Header
    {
        private string format;
        private string length;
        private Day day;
        private Month month;
        private Year year;
        private Separator separator;
        private string weekStart;


        public string WeekStart
        {
            get { return weekStart; }
            set { weekStart = value; }
        }
        public string Format
        {
            get { return format; }
            set { format = value; }
        }
        public string Length
        {
            get { return length; }
            set { length = value; }
        }

        public Day Day
        {
            get { return day; }
            set { day = value; }
        }

        public Month Month
        {
            get { return month; }
            set { month = value; }
        }
        public Year Year
        {
            get { return year; }
            set { year = value; }
        }
        public Separator Separator
        {
            get { return separator; }
            set { separator = value; }
        }
        public Date() {
            format = "";
        }
    }
    public class Day : Date
    {
        public Day(){}
    }
    public class Month : Date
    {
        public Month() { }
    }
    public class Year : Date
    {
        public Year() { }
    }
    public class Separator : Date
    {
        public Separator() { }
    }
    public class Shade : Header
    {
        #region Private
        private string style;
        private decimal opacity;

        public string Style { get { return style; } set { style = value; } }
        public decimal Opacity { get { return opacity; } set { opacity = value; } }
        #endregion
        #region Properties
        #endregion
        public Shade() { }
    }
    public class Item : Header
    {
        public Item() { }
    }
    public class Border : Header {

        private decimal top;
        private decimal bottom;

        public decimal Top { get { return top; } set { top = value; } }
        public decimal Bottom { get { return bottom; } set { bottom = value; } }
        public Border() {
            top = 0;
            bottom = 0;
        }
    }
    public class Greeting : Header {
        public Greeting() {
        }
    }
    public class Transitional : Header
    {
        public Transitional()
        {

        }
    }

    #endregion


}
