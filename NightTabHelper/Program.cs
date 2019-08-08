using Newtonsoft.Json;
using NightTabHelper.Classes;
using NightTabHelper.Classes.BookmarkClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NightTabHelper
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public string bookmarkjs = "";
        public string statejs = "";
        public string bookmarksFile = "";
        public string stateFile = "";
        bool error = false;
        public NightTabClass nightTab = new NightTabClass();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NightTabHelper());
        }

        public void selectButtonClicked(OpenFileDialog openFileDialog1, List<Button> btnList)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    ParseInput(sr.ReadToEnd());
                    CreateFile();
                    if (!error)
                    {
                        btnList[0].Visible = false;
                        btnList[1].Visible = true;
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}");
                }
            }
        }

        public void exportButtonClicked(List<Button> btnList)
        {
            WriteOutFile(bookmarksFile, "bookmarks");
            WriteOutFile(stateFile, "state");
            if (!error)
            {
                btnList[0].Visible = true;
                btnList[1].Visible = false;
            }
        }

        private void CreateFile()
        {
            try
            {
                bookmarkjs = "";
                foreach (Bookmark bm in nightTab.Bookmarks)
                {
                    string tempBookmarks = "";
                    List<string> valueList = new List<string>();
                    valueList.Add(bm.Display);//0
                    valueList.Add(bm.Letter);//1
                    valueList.Add(bm.Icon.Name);//2
                    valueList.Add(bm.Icon.Prefix);//3
                    valueList.Add(bm.Icon.Label);//4
                    valueList.Add(bm.Name);//5
                    valueList.Add(bm.Url);//6
                    valueList.Add(bm.Accent.OverRide);//7
                    valueList.Add(bm.Accent.Color.R);//8
                    valueList.Add(bm.Accent.Color.G);//9
                    valueList.Add(bm.Accent.Color.B);//10
                    valueList.Add(bm.Timestamp);//11

                    tempBookmarks += "[\ndisplay: \"{0}\", \n" +
                                    "letter: \"{1}\", \n" +
                                    "icon: [\n name: \"{2}\",\n prefix: \"{3}\",\n label: \"{4}\"\n],\n  " +
                                    "name: \"{5}\",\n  " +
                                    "url: \"{6}\",\n" +
                                    "accent: [\n" +
                                    "override: {7},\n" +
                                    "color: [ \n" +
                                    "r: {8}, \n" +
                                    "g: {9}, \n" +
                                    "b: {10}\n" +
                                    "]\n" +
                                    "], \n " +
                                    "timeStamp: {11}\n]";
                    if (bm != nightTab.Bookmarks.Last())
                    {
                        tempBookmarks += ",";
                    }

                    bookmarkjs += string.Format(tempBookmarks, valueList.ToArray()).Replace("[", "{").Replace("]", "}");
                }
                var sr = new StreamReader(Environment.CurrentDirectory.Replace("bin", "Output").Replace("Debug", "oldBookmarks.js"));
                bookmarksFile = sr.ReadToEnd().Replace("{0}", bookmarkjs);
            }
            catch (Exception ee)
            {
                error = true;
                MessageBox.Show($"error writing new bookmarks.js file.\n\nError message: {ee.Message}");
            }

            try {
                statejs = "";
                List<string> valueList = new List<string>();
                #region Building Value List
                valueList.Add(nightTab.State.Header.Area.Width.ToString().ToLower()); //Header.Area
                valueList.Add(nightTab.State.Header.Area.Alignment.ToString().ToLower());//Header.Area
                valueList.Add(nightTab.State.Header.Item.Alignment.ToString().ToLower());//Header.Item
                valueList.Add(nightTab.State.Header.Clock.Hours.Show.ToString().ToLower());//Header.Clock
                valueList.Add(nightTab.State.Header.Clock.Hours.Display.ToString().ToLower());//Header.Clock
                valueList.Add(nightTab.State.Header.Clock.Minutes.Show.ToString().ToLower());//Header.Clock
                valueList.Add(nightTab.State.Header.Clock.Minutes.Display.ToString().ToLower());//Header.Clock
                valueList.Add(nightTab.State.Header.Clock.Seconds.Show.ToString().ToLower());//Header.Clock
                valueList.Add(nightTab.State.Header.Clock.Seconds.Display.ToString().ToLower());//Header.Clock
                valueList.Add(nightTab.State.Header.Clock.Separator.Show.ToString().ToLower());//Header.Clock
                valueList.Add(nightTab.State.Header.Clock.Meridiem.Show.ToString().ToLower());//Header.Clock
                valueList.Add(nightTab.State.Header.Clock.Hour24.Show.ToString().ToLower());//Header.Clock
                valueList.Add(nightTab.State.Header.Clock.Size.ToString().ToLower());//Header.Clock
                valueList.Add(nightTab.State.Header.Date.Day.Show.ToString().ToLower());//Header.Date
                valueList.Add(nightTab.State.Header.Date.Day.Display.ToString().ToLower());//Header.Date
                valueList.Add(nightTab.State.Header.Date.Day.WeekStart.ToString().ToLower());//Header.Date
                valueList.Add(nightTab.State.Header.Date.Day.Length.ToString().ToLower());//Header.Date
                valueList.Add(nightTab.State.Header.Date.Date.Show.ToString().ToLower());//Header.Date
                valueList.Add(nightTab.State.Header.Date.Date.Display.ToString().ToLower());//Header.Date
                valueList.Add(nightTab.State.Header.Date.Date.Ordinal.ToString().ToLower());//Header.Date
                valueList.Add(nightTab.State.Header.Date.Month.Show.ToString().ToLower());//Header.Date
                valueList.Add(nightTab.State.Header.Date.Month.Display.ToString().ToLower());//Header.Date
                valueList.Add(nightTab.State.Header.Date.Month.Length.ToString().ToLower());//Header.Date
                valueList.Add(nightTab.State.Header.Date.Month.Ordinal.ToString().ToLower());//Header.Date
                valueList.Add(nightTab.State.Header.Date.Year.Show.ToString().ToLower());//Header.Date
                valueList.Add(nightTab.State.Header.Date.Year.Display.ToString().ToLower());//Header.Date
                valueList.Add(nightTab.State.Header.Date.Separator.Show.ToString().ToLower());//Header.Date
                valueList.Add(nightTab.State.Header.Date.Format.ToString().ToLower());//Header.Date
                valueList.Add(nightTab.State.Header.Date.Size.ToString().ToLower());//Header.Date
                valueList.Add(nightTab.State.Header.Search.Show.ToString().ToLower());//Header.Search
                valueList.Add(nightTab.State.Header.Search.Style.ToString().ToLower());//Header.Search
                valueList.Add(nightTab.State.Header.Search.Width.ToString().ToLower());//Header.Search
                valueList.Add(nightTab.State.Header.Search.Focus.ToString().ToLower());//Header.Search
                valueList.Add(nightTab.State.Header.Search.Engine.Selected.ToString().ToLower());//Header.Search -33
                valueList.Add(nightTab.State.Header.Search.Engine.Custom.Url.ToString().ToLower());//Header.Search
                valueList.Add(nightTab.State.Header.Search.Engine.Custom.Name.ToString().ToLower());//Header.Search
                valueList.Add(nightTab.State.Header.Search.Text.Alignment.ToString().ToLower());//Header.Search
                valueList.Add(nightTab.State.Header.Search.Size.ToString().ToLower());//Header.Search
                valueList.Add(nightTab.State.Header.Button.EditAdd.Show.ToString().ToLower());//Header.Button
                valueList.Add(nightTab.State.Header.Button.Accent.Show.ToString().ToLower());//Header.Button
                valueList.Add(nightTab.State.Header.Button.Style.ToString().ToLower());//Header.Button
                valueList.Add(nightTab.State.Header.Button.Size.ToString().ToLower());//Header.Button -41
                valueList.Add(nightTab.State.Header.Shade.Show.ToString().ToLower());//Header.Shade
                valueList.Add(nightTab.State.Header.Shade.Style.ToString().ToLower());//Header.Shade
                valueList.Add(nightTab.State.Header.Shade.Opacity.ToString().ToLower());//Header.Shade - 44
                valueList.Add(nightTab.State.Header.Border.Top.ToString().ToLower());//Header.Border
                valueList.Add(nightTab.State.Header.Border.Bottom.ToString().ToLower());//Header.Border
                valueList.Add(nightTab.State.Header.Greeting.Show.ToString().ToLower());//Header.Greeting
                valueList.Add(nightTab.State.Header.Greeting.Type.ToString().ToLower());//Header.Greeting
                valueList.Add(nightTab.State.Header.Greeting.Name.ToString());//Header.Greeting
                valueList.Add(nightTab.State.Header.Greeting.Size.ToString().ToLower());//Header.Greeting
                valueList.Add(nightTab.State.Header.Transitional.Show.ToString().ToLower());//Header.Transitional
                valueList.Add(nightTab.State.Header.Transitional.Type.ToString().ToLower());//Header.Transitional
                valueList.Add(nightTab.State.Header.Transitional.Size.ToString().ToLower());//Header.Transitional 
                valueList.Add(nightTab.State.Header.Radius.ToString().ToLower());//Header.Transitional - 54
                valueList.Add(nightTab.State.Link.Area.Width.ToString().ToLower());//Link.Area
                valueList.Add(nightTab.State.Link.Area.Alignment.ToString().ToLower());//Link.Area
                valueList.Add(nightTab.State.Link.Item.Display.Show.ToString().ToLower());//Link.Item
                valueList.Add(nightTab.State.Link.Item.Display.Size.ToString().ToLower());//Link.Item
                valueList.Add(nightTab.State.Link.Item.Display.Alignment.ToString().ToLower());//Link.Item
                valueList.Add(nightTab.State.Link.Item.Display.Letter.Size.ToString().ToLower());//Link.Item
                valueList.Add(nightTab.State.Link.Item.Display.Icon.Size.ToString().ToLower());//Link.Item
                valueList.Add(nightTab.State.Link.Item.Name.Show.ToString().ToLower());//Link.Item
                valueList.Add(nightTab.State.Link.Item.Name.Size.ToString().ToLower());//Link.Item - 63
                valueList.Add(nightTab.State.Link.Item.Url.Show.ToString().ToLower());//Link.Item
                valueList.Add(nightTab.State.Link.Item.Line.Show.ToString().ToLower());//Link.Item
                valueList.Add(nightTab.State.Link.Item.HoverScale.Show.ToString().ToLower());//Link.Item
                valueList.Add(nightTab.State.Link.Item.Order.ToString().ToLower());//Link.Item
                valueList.Add(nightTab.State.Link.Item.Size.ToString().ToLower());//Link.Item
                valueList.Add(nightTab.State.Link.Item.NewTab.ToString().ToLower());//Link.Item -69
                valueList.Add(nightTab.State.Link.Show.ToString().ToLower());//Link.Show
                valueList.Add(nightTab.State.Link.Edit.ToString().ToLower());//Link.Edit
                valueList.Add(nightTab.State.Link.Style.ToString().ToLower());//Link.Style
                valueList.Add(nightTab.State.Link.NewTab.ToString().ToLower());//Link.NewTab
                valueList.Add(nightTab.State.Layout.Alignment.ToString().ToLower());//Layout.Alignment
                valueList.Add(nightTab.State.Layout.Order.ToString().ToLower());//Layout.Order
                valueList.Add(nightTab.State.Layout.Padding.ToString().ToLower());//Layout.Padding
                valueList.Add(nightTab.State.Layout.Gutter.ToString().ToLower());//Layout.Gutter
                valueList.Add(nightTab.State.Layout.Width.ToString().ToLower());//Layout.Width
                valueList.Add(nightTab.State.Layout.ScrollPastEnd.ToString().ToLower());//Layout.ScrollPastEnd
                valueList.Add(nightTab.State.Layout.Title.ToString());//Layout.Title - 80
                valueList.Add(nightTab.State.Theme.Accent.Current.R.ToString().ToLower());//Theme.Accent
                valueList.Add(nightTab.State.Theme.Accent.Current.G.ToString().ToLower());//Theme.Accent
                valueList.Add(nightTab.State.Theme.Accent.Current.B.ToString().ToLower());//Theme.Accent
                valueList.Add(nightTab.State.Theme.Accent.Random.Active.ToString().ToLower());//Theme.Accent
                valueList.Add(nightTab.State.Theme.Accent.Random.Style.ToString().ToLower());//Theme.Accent
                valueList.Add(nightTab.State.Theme.Style.ToString().ToLower());//Theme.Style
                valueList.Add(nightTab.State.Theme.Radius.ToString().ToLower());//Theme.Radius -87
                valueList.Add(nightTab.State.Background.Image.Show.ToString().ToLower());//Background.Image
                valueList.Add(nightTab.State.Background.Image.Url.ToString().ToLower());//Background.Image
                valueList.Add(nightTab.State.Background.Image.Blur.ToString().ToLower());//Background.Image
                valueList.Add(nightTab.State.Background.Image.Scale.ToString().ToLower());//Background.Image
                valueList.Add(nightTab.State.Background.Image.Opacity.ToString().ToLower());//Background.Image
                valueList.Add(nightTab.State.Background.Image.Grayscale.ToString().ToLower());//Background.Image
                valueList.Add(nightTab.State.Background.Image.Accent.ToString().ToLower());//Background.Image
                valueList.Add(nightTab.State.Edge.ToString().ToLower());//Edge
                valueList.Add(nightTab.State.Search.ToString().ToLower());//Search
                valueList.Add(nightTab.State.Menu.ToString().ToLower());//Menu
                valueList.Add(nightTab.State.Modal.ToString().ToLower());//Modal
                valueList.Add(nightTab.State.AutoSuggest.ToString().ToLower());//AutoSuggest - 99
                #endregion
                var sr = new StreamReader(Environment.CurrentDirectory.Replace("bin", "Output").Replace("Debug", "oldState.js"));
                stateFile = String.Format(sr.ReadToEnd(), valueList.ToArray());
                stateFile = stateFile.Replace('¿', '{').Replace('╡', '}');
            }

            catch (Exception ee)
            {

                error = true;
                MessageBox.Show($"error writing new state.js file.\n\nError message: {ee.Message}");
            }
                
        }

        private  void WriteOutFile(string outputData, string fileType)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "JS File| *.js";
                saveFileDialog1.Title = "Save a " + fileType + " File";
                saveFileDialog1.FileName = fileType;
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, outputData);
                }
                //System.IO.File.WriteAllText(Environment.CurrentDirectory.Replace("bin", "Output").Replace("Debug", "bookmarks.js"), outputData);
            }
            catch (Exception ee)
            {
                error = true;
                MessageBox.Show($"error writing file.\n\nError message: {ee.Message}");
            }
            finally
            {
                if (!error)
                {
                    MessageBox.Show($"{fileType} file Created Successfully");
                }
            }
        }

        private void ParseInput(string inputData)
        {
            try
            {

                JsonSerializerSettings jss = new JsonSerializerSettings();
                jss.NullValueHandling = NullValueHandling.Ignore;
                nightTab = JsonConvert.DeserializeObject<NightTabClass>(inputData, jss);
            }
            catch (Exception ee)
            {
                error = true;
                MessageBox.Show($"error parsing json.\n\nError message: {ee.Message}");
            }
    
        }

    }

}



 //display: "icon", 
 //letter: "Amazon", 
 //icon: { 
 //name: "amazon", 
 //prefix: "fab", 
 //label: "Amazon" 
 //}, 
 //name: "Amazon", 
 //url: "https://smile.amazon.com/", 
 //accent: { 
 //override: true, 
 //color: { 
 //r: 243, 
 //g: 168, 
 //b: 71 
 //} 
 //}, 
 //timeStamp: 1546453100455 
 //},{
 //display: "letter", 
 //letter: "A", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "Awesomer", 
 //url: "https://theawesomer.com/", 
 //accent: { 
 //override: true, 
 //color: { 
 //r: 142, 
 //g: 142, 
 //b: 142 
 //} 
 //}, 
 //timeStamp: 1543453100455 
 //},{
 //display: "icon", 
 //letter: "Calendar", 
 //icon: { 
 //name: "calendar", 
 //prefix: "fas", 
 //label: "Calendar" 
 //}, 
 //name: "Calendar", 
 //url: "https://www.google.com/calendar/", 
 //accent: { 
 //override: true, 
 //color: { 
 //r: 26, 
 //g: 115, 
 //b: 232 
 //} 
 //}, 
 //timeStamp: 1546453110885 
 //},{
 //display: "letter", 
 //letter: "Deluge", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "https://deluge.kylehart1213.com/", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1546453121953 
 //},{
 //display: "letter", 
 //letter: "Drive", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "https://drive.google.com/drive/", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1546853111953 
 //},{
 //display: "letter", 
 //letter: "Github", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "https://github.com/", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1546453108926 
 //},{
 //display: "letter", 
 //letter: "Gmail", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "https://mail.google.com/", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1546453110265 
 //},{
 //display: "letter", 
 //letter: "IpTorrents", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "https://www.iptorrents.com/", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1546453110205 
 //},{
 //display: "letter", 
 //letter: "Kids Movies", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "kidsmovies", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1596453111953 
 //},{
 //display: "letter", 
 //letter: "Movies", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "movies", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1596453111953 
 //},{
 //display: "letter", 
 //letter: "Netflix", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "https://www.netflix.com/", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1546453104460 
 //},{
 //display: "letter", 
 //letter: "Octoprint", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "https://www.dsk3dprinting.com", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1546453111155 
 //},{
 //display: "letter", 
 //letter: "Ombi", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "https://ombi.kylehart1213.com/", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1546453111153 
 //},{
 //display: "letter", 
 //letter: "Photos", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "https://photos.google.com/", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1546453104910 
 //},{
 //display: "letter", 
 //letter: "Plex", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "https://plex.kylehart1213.com/", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1546453111353 
 //},{
 //display: "letter", 
 //letter: "Radarr", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "https://radarr.kylehart1213.com/", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1546453181953 
 //},{
 //display: "letter", 
 //letter: "Reddit", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "https://www.reddit.com/", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1546453111491 
 //},{
 //display: "letter", 
 //letter: "Speed.CD", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "https://www.speed.cd", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1546453191958 
 //},{
 //display: "letter", 
 //letter: "Sonarr", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "https://sonarr.kylehart1213.com/", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1546453191953 
 //},{
 //display: "letter", 
 //letter: "Jackett", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "https://jackett.kylehart1213.com/", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1546412131953 
 //},{
 //display: "letter", 
 //letter: "Tautulli", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "https://stats.kylehart1213.com/", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1546453113953 
 //},{
 //display: "letter", 
 //letter: "TFS", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "https://tfs.pathguide.com", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1546453113950 
 //},{
 //display: "letter", 
 //letter: "Thingiverse", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "https://www.thingiverse.com", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1546103113953 
 //},{
 //display: "letter", 
 //letter: "TorrentSeeds", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "https://torrentseeds.org/", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1146103113953 
 //},{
 //display: "letter", 
 //letter: "UnRaid", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "http://192.168.1.149/Main", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 9866453113953 
 //},{
 //display: "letter", 
 //letter: "TV", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "tv", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1546453111953 
 //},{
 //display: "letter", 
 //letter: "Youtube", 
 //icon: { 
 //name: "", 
 //prefix: "", 
 //label: "" 
 //}, 
 //name: "", 
 //url: "https://www.youtube.com/", 
 //accent: { 
 //override: false, 
 //color: { 
 //r: null, 
 //g: null, 
 //b: null 
 //} 
 //}, 
 //timeStamp: 1546453108071 
 
