using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormV_Hov
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                string firstPart = "";
                string secondPart = "";

                if (txt.Text != " ")
                {
                    firstPart = char.ToUpper(txt.Text[0]).ToString();
                    for (int i = 1; i < txt.Text.Length; i++)
                    {
                        if (txt.Text[i] != ' ')
                            secondPart += (char.ToLower(txt.Text[i])).ToString();
                        else
                            break;
                    }
                    txt.Text = firstPart + secondPart;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(1);
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (txtMail.Text != "") && (maskedTextBox1.Text != "") && (textBox6.Text != "") && (comboBox1.Text != ""))
            {
                if (txtMail.Text.Contains("@") && txtMail.Text.Contains(".") && txtMail.Text.Length > 3)
                {
                    MessageBox.Show("Thank you for registration!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Login_Form f = new Login_Form();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Your email is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login_Form f = new Login_Form();
            f.Show();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            txtMail.Clear();
            textBox6.Clear();
            comboBox1.Text = "";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            OpenFileDialog oFD = new OpenFileDialog()
            {
                Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp",
                InitialDirectory = @"C:\Users\User\Desktop\Pictures",
                Multiselect = false,
            };
            if (oFD.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = new Bitmap(oFD.FileName);
        }

    }
}
