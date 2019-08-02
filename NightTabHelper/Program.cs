using Newtonsoft.Json;
using NightTabHelper.Classes;
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
        bool error = false;
        public static List<NightTabClass> ntList;
        public NightTabClass nightTab = new NightTabClass();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private void SetText(string text)
        {

        }


        public void buttonClicked(OpenFileDialog openFileDialog1)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    ParseInput(sr.ReadToEnd());
                    CreateFile();
                    WriteOutFile(bookmarksFile);
                    if (!error)
                    {
                        MessageBox.Show($"File Created Successfully");
                    }

                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}");
                }
            }
        }

        private void CreateFile()
        {

            try
            {
                bookmarkjs = "" ;
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
                    valueList.Add(bm.Accent.color.R);//8
                    valueList.Add(bm.Accent.color.G);//9
                    valueList.Add(bm.Accent.color.B);//10
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
                MessageBox.Show($"error writing new string.\n\nError message: {ee.Message}");
            }
        }

        private  void WriteOutFile(string outputData)
        {
            try {
                System.IO.File.WriteAllText(Environment.CurrentDirectory.Replace("bin", "Output").Replace("Debug", "bookmarks.js"), outputData);
            }
            catch (Exception ee)
            {
                error = true;
                MessageBox.Show($"error writing file.\n\nError message: {ee.Message}");
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
 
