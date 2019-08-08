using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NightTabHelper
{
    public partial class NightTabHelper : Form
    {
        public Program program;
        public List<Button> btnList;

        public NightTabHelper()
        {
            InitializeComponent();
            program = new Program();
            btnList = new List<Button>();
            btnList.Add(selectBtn);
            btnList.Add(exportBtn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            program.selectButtonClicked(openFileDialog1, btnList);
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Welcome to the Night Tab helper app.This was designed for the users who wish to host thier own version of Night Tab and do not want to setup all thier bookmarks across all browsers." +
               "" +
               "The steps to follow are pretty simple,\n\nStep 1: setup night tabs bookmarks and settings as you normally would using the Night Tab gui. \n\nStep 2: Next you need export the data to a json backup file. \n\nStep 3: Once you have exported the data, import the json file into the Night Tab Helper app and it will create a new Bookmarks.js file as well as a new State.js file for you.\n\nStep 4: Next you just need to replace those 2 files on you webserver.\n\n\nIf there are any issues submit an issue on the github page", "Nighttab Helper Readme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "https://github.com/hartk1213/NightTabHelper/issues/new", "keyword");
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            program.exportButtonClicked(btnList);
        }
    }
}
