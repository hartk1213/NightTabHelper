using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.Classes.StateClasses.HeaderClasses
{
    public class Search : Header
    {
        #region Private

        private decimal width;
        private string style;
        private bool focus;
        private Engine engine;
        private Text text;

        #endregion
        #region Properties
        public decimal Width { get { return width; } set { width = value; } }
        public string Style { get { return style; } set { style = value; } }
        public Text Text { get { return text; } set { text = value; } }
        public bool Focus { get { return focus; } set { focus = value; } }
        public Engine Engine { get { return engine;  } set { engine = value; } }
        #endregion
        public Search() {
            width = 0;
            focus = false;
        }
    }

    #region subClasses

    public class Engine : Search
    {

        private string selected;
        private string url;
        private Custom custom;
        public string Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        public Custom Custom
        {
            get { return custom; }
            set { custom = value; }
        }
        public string Url
        {
            get {return url; } set { url = value; }
        }

        public Engine() {
            selected = "";
            url = "";
        }

    }
    #region SearchEngines
    public class Google : Engine
    {
        public Google()
        {
            Url = "https://www.google.com/search";
            Name = "Google";
        }
    }
    public  class DuckDuckGo : Engine
    {
        public DuckDuckGo()
        {
            Url = "https://duckduckgo.com/";
            Name = "DuckDuckGo";
        }


    }
    public  class Youtube : Engine
    {
        public Youtube()
        {
            Url = "https://www.youtube.com/results?search_query=";
            Name = "Youtube";
        }
    }
    public  class Giphy : Engine
    {
        public Giphy()
        {
            Url = "https://giphy.com/search/";
            Name = "Giphy";
        }
    }
    public  class Bing : Engine
    {
        public Bing()
        {
            Url = "https://www.bing.com/search?q=";
            Name = "Bing";
        }
    }
    public  class Custom : Engine
    {
        public Custom()
        {
            Url = "";
            Name = "";
        }

    }
    #endregion
    public class Text : Search
    {

        public Text() { }
    }
    #endregion
}
