using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Test1
{
    public partial class Form1 : Form
    {
        SoundPlayer player = null;
        string fileName = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player = new SoundPlayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                player.SoundLocation = fileName;
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog()
            {
                Filter = "WAV|*.wav",

                Multiselect = true,

                
            };
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                fileName = oFD.FileName;

                //textBox1.Text += player.Tag;

                byte[] b = new byte[128];
                string sTitle;
                string sSinger;
                string sAlbum;
                string sYear;
                string sComm;

                FileStream fs = new FileStream(fileName, FileMode.Open);
                fs.Seek(-128, SeekOrigin.End);
                fs.Read(b, 0, 128);
                bool isSet = false;
                String sFlag = System.Text.Encoding.Default.GetString(b, 0, 3);
                if (sFlag.CompareTo("TAG") == 0)
                {
                    System.Console.WriteLine("Tag   is   setted! ");
                    isSet = true;
                }

                if (isSet)
                {
                    //get   singer;
                    sSinger = System.Text.Encoding.Default.GetString(b, 33, 30);
                    textBox1.Text = "Singer: " + sSinger;
                    //get   album;
                    sAlbum = System.Text.Encoding.Default.GetString(b, 63, 30);
                    textBox1.Text += "Album: " + sAlbum;
                }
            }
        }
    }
}
