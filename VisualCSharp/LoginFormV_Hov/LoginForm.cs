using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormV_Hov
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        public void btnSignIn_Click(object sender, EventArgs e)
        {
            LoginEnter();
        }

        public void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void lblHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Here is useful inforation");
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            linkLabel2.Enabled = !linkLabel1.Enabled;
        }

        public void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtLogin.Clear();
            txtPassword.Clear();
        }

        public void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                txtPassword.PasswordChar = '\0'; 
            else
                txtPassword.PasswordChar = '*';
        }

        public void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration rg = new Registration();
            this.Hide();
            rg.Show();
        }

        public void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoginEnter();
            }
        }
        public void LoginEnter()
        {
            if (txtLogin.Text == "user" && txtPassword.Text == "root")
            {
                MainForm mF = new MainForm();
                mF.Show();
                this.Hide();
            }
            else
            {
                txtLogin.Clear();
                txtPassword.Clear();
                checkBox2.Checked = false;
                MessageBox.Show("You enter invalid login or password");
            }
        }
    }
}
