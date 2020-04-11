using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Test2
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }
        #region Properties
        private string _sArtist;
        private string _sName;
        private string _sTime;
        private bool _sChecked;

        [Category("Custom Props")]
        public string SArtist
        {
            get { return _sArtist; }
            set { _sArtist = value; lblSArtist.Name = value; }
        }

        [Category("Custom Props")]
        public string SName
        {
            get { return _sName; }
            set { _sName = value; lblSName.Text = value; }
        }
        [Category("Custom Props")]
        public string STime
        {
            get { return _sTime; }
            set { _sTime = value; lblSTime.Text = value; }
        }

        [Category("Custom Props")]
        public bool sChecked
        {
            get { return _sChecked; }
            set { _sChecked = value;}
        }
        #endregion

        Color color;
        private void ListItem_MouseEnter(object sender, EventArgs e)
        {
            if (!this._sChecked)
            {
                color = this.BackColor;
                this.BackColor = Color.FromArgb(230, 230, 230);
            }
        }

        private void ListItem_MouseLeave(object sender, EventArgs e)
        {
            if (!this._sChecked) 
            {
                if (color == Color.FromArgb(242, 242, 242))
                    this.BackColor = Color.FromArgb(242, 242, 242);
                else if (color == Color.FromArgb(29, 112, 126))
                    this.BackColor = Color.FromArgb(29, 112, 126);
                else if (color == Color.White)
                    this.BackColor = Color.White; 
            }
        }

        private void ListItem_Click(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(29, 112, 126);
            this._sChecked = true;
        }
    }
}
