using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition,ToolStripDropDownDirection.Right);
            }
        }

        private void иToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //В буфер обмена
            Clipboard.SetText(listBox1.SelectedItem.ToString());
        }
    }
}
