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
    public partial class Form1 : Form
    {
        public Program program;
        public static List<Header> hcList;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            program.buttonClicked(openFileDialog1);
        }
    }
}
