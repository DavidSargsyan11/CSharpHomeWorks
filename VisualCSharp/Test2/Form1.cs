using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Media;
using System.IO;
using System.Runtime.InteropServices;

namespace Test2
{
    public partial class Form1 : Form
    {
        #region GlobalVariables
        int tabIndex = 1;
        int mov, movX, movY;
        bool maximized = false;
        string playIndex = "zero";
        SoundPlayer player = null;
        //int mChecked = 0;

        //SoundPlayer player = null;
        private Mp3Player _mp3Player;

        //List<ListItem> listitems = new List<ListItem>();
        List<String> listitemsName = new List<String>();
        List<String> listitemsPath = new List<String>();
        List<String> listitemsArtist = new List<String>();
        List<String> listitemsGenre = new List<String>();
        List<String> listitemsDuration = new List<String>();

        #endregion



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "A to Z";
            comboBox2.SelectedItem = "All Genres";

            trackBar1.Value = 500;
        }

        private void btnAddMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog()
            {
                Filter = "Mp3 File|*.mp3",
                InitialDirectory = @"C:\Users\User\Desktop\Music\Playlist",
                Multiselect = true,
            };
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in oFD.FileNames)
                {
                    Mp3Lib.Mp3File mFile = new Mp3Lib.Mp3File(file);
                    _mp3Player = new Mp3Player("0");
                    listitemsPath.Add(file);
                    listitemsName.Add(Path.GetFileName(file));
                    ListViewItem item = new ListViewItem(listitemsName[listitemsPath.Count - 1]);
                    string artist = null, genre = null;

                    try
                    {
                        artist = mFile.TagHandler.Artist;
                        genre = mFile.TagHandler.Genre;

                    }
                    catch (Exception)
                    {

                    }

                    if (artist != null)
                        listitemsArtist.Add(artist);
                    else
                        listitemsArtist.Add("Uncnown");
                    item.SubItems.Add(listitemsArtist[listitemsPath.Count - 1]);

                    if (genre != null)
                    {
                        listitemsGenre.Add(genre);
                        if (!comboBox2.Items.Contains(genre))
                            comboBox2.Items.Add(genre);
                    }
                    else
                        listitemsGenre.Add(" ");

                    item.SubItems.Add(listitemsGenre[listitemsPath.Count - 1]);

                    listView1.Items.Add(item);
                    if ((listitemsName.Count - 1) % 2 == 1)
                        listView1.Items[listitemsName.Count - 2].BackColor = Color.FromArgb(242, 242, 242);

                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            _mp3Player.Dispose();
            Mp3Lib.Mp3File mFile;
            //player = new SoundPlayer();

            string dockName;

            if (listView1.SelectedIndices.Count > 0)
            {
                Mp3Player _mp3Player = new Mp3Player(listitemsPath[listView1.SelectedItems[0].Index]);
                mFile = new Mp3Lib.Mp3File(listitemsPath[listView1.SelectedItems[0].Index]);
                //player.SoundLocation = listitemsPath[listView1.SelectedItems[0].Index];
                dockName = Path.GetFileName(listitemsPath[listView1.SelectedItems[0].Index]);
            }
            else
            {
                Mp3Player _mp3Player = new Mp3Player(listitemsPath[listView1.Items[0].Index]);
                mFile = new Mp3Lib.Mp3File(listitemsPath[listView1.Items[0].Index]);
                //player.SoundLocation = listitemsPath[listView1.Items[0].Index];
                dockName = Path.GetFileName(listitemsPath[listView1.Items[0].Index]);
            }
            string dockTitle = null;
            Image dockPicture = null;
            try
            {
                if (dockName != null)
                    lblBSName.Text = dockName;

                dockTitle = mFile.TagHandler.Artist;
                dockPicture = mFile.TagHandler.Picture;

            }
            catch (Exception)
            {

            }
            if (dockTitle != null)
                label4.Text = dockTitle;
            else
                label4.Text = "Uncnown";

            if (dockPicture != null)
                pictureBox1.Image = new Bitmap(dockPicture);
            else
                pictureBox1.Image = Resource1.Def;

            _mp3Player.SetVolume(trackBar1.Value);
            if (_mp3Player != null)
            {
                _mp3Player.Play();
            }
                 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _mp3Player.SetVolume(trackBar1.Value);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (maximized)
            {
                WindowState = FormWindowState.Normal;
                maximized = false;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                maximized = true;
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #region FormDesignEvents  
        private void btnSong_MouseEnter(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.ForeColor = Color.Black;
        }

        private void btnSong_MouseLeave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.ForeColor = Color.FromArgb(229, 229, 229);
            if (tabIndex == 1)
            {
                btnSong.ForeColor = Color.Black;
            }
            if (tabIndex == 2)
            {
                btnArtists.ForeColor = Color.Black;
            }
            if (tabIndex == 3)
            {
                btnAlbums.ForeColor = Color.Black;
            }
        }
        private void btnSong_MouseDown(object sender, MouseEventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.Gray;
        }

        private void btnSong_MouseUp(object sender, MouseEventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.White;
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel6_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panel6_DoubleClick(object sender, EventArgs e)
        {
            if (maximized)
            {
                WindowState = FormWindowState.Normal;
                maximized = false;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                maximized = true;
            }
        }
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
            btnExit.ForeColor = Color.White;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.White;
            btnExit.ForeColor = Color.Black;
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            ComboBox bt = (ComboBox)sender;
            bt.ForeColor = Color.Black;
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox bt = (ComboBox)sender;
            bt.ForeColor = Color.FromArgb(29, 112, 126);
        }



        private void btnFullScreen_MouseDown(object sender, MouseEventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.FromArgb(29, 112, 126);
        }

        private void btnFullScreen_MouseUp(object sender, MouseEventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.White;
        }


        #endregion
    }
}
