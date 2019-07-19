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
        public static List<Bookmark> hcList;
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
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }


        private static void WriteOutFile()
        {
            string itemTemplate = "[\r\n display: \"letter\", \r\n letter: {0}, \r\n icon: [ \r\n name: \"\", \r\n prefix: \"\", \r\n label: \"\" \r\n ], \r\n name: {1}, \r\n url: {2}, \r\n accent: [ \r\n override: false, \r\n color: [ \r\n r: null, \r\n g: null, \r\n b: null \r\n ] \r\n ], \r\n timeStamp: {3} \r\n ]";
            string outputData = "";

            foreach (Bookmark hc in hcList)
            {
                if (hc == hcList.Last())
                {
                    outputData = outputData + string.Format(itemTemplate, hc.Letter, hc.Name, hc.Url, hc.Timestamp);
                }
                else
                {
                    outputData = outputData + string.Format(itemTemplate, hc.Letter, hc.Name, hc.Url, hc.Timestamp) + ",";
                }
            }
            outputData = outputData.Replace('[', '{').Replace(']', '}');
            System.IO.File.WriteAllText(@"C:\Users\khart\Documents\outputData.txt", outputData);
        }

        private static void ParseInput(string inputData)
        {

            var test = JsonConvert.DeserializeObject(inputData);
            //inputData = inputData.Replace("\\r\\n", "");
            //inputData = inputData.Trim();
            //List<string> list1 = new List<string>();
            //List<string> list2 = new List<string>();
            //List<string> list3 = new List<string>();
            //List<string> list4 = new List<string>();
            //list1 = inputData.Split('|').ToList();
            //foreach (string str in list1)
            //{
            //    Header hc = new Header();
            //    list2 = str.Split(',').ToList();
            //    foreach (string str2 in list2)
            //    {
            //        list3 = str2.Split('?').ToList();
            //        foreach (string str3 in list3)
            //        {

            //            switch (str3.Trim())
            //            {
            //                case "letter":
            //                    hc.Letter = list3[1].Trim();
            //                    break;
            //                case "name":
            //                    hc.Name = list3[1].Trim();
            //                    break;
            //                case "url":
            //                    hc.Url = list3[1].Trim();
            //                    break;
            //                case "timeStamp":
            //                    hc.Timestamp = list3[1].Trim();
            //                    break;
            //            }
            //        }
            //    }
            //    hcList.Add(hc);
            //}
        }

    }

}
