using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FileManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void pathAdd()
        {
            listBox1.Items.Clear();

            DirectoryInfo dir = new DirectoryInfo(textBox1.Text);

            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach (DirectoryInfo crrDir in dirs)
            {
                listBox1.Items.Add(crrDir);
            }

            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo crrFile in files)
            {
                listBox1.Items.Add(crrFile);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pathAdd();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (Path.GetExtension(Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString())) == "")
            {
                textBox1.Text = Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString());
                pathAdd();
            }
            else
                Process.Start(Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString()));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            do
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            } while (textBox1.Text[textBox1.Text.Length - 1] != '\\');

            pathAdd();
        }
    }
}
