using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
//using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
//using SpreadsheetLight;

namespace Calculadoras
{
    public partial class SignUp : Form
    {
        string user = "", pass = "", pass2 = "";
        public SignUp()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            pass = textBox3.Text;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            user = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pass2 = textBox2.Text;
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Login login = new Login();
            login.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Regex.IsMatch(user, @"[^a-zA-Z0-9]") || Regex.IsMatch(pass, @"[^a-zA-Z0-9]") || Regex.IsMatch(pass2, @"[^a-zA-Z0-9]"))
            {
                if (Regex.IsMatch(user, @"[^a-zA-Z0-9]"))
                {
                    txtuser.Show();
                    txtuser.Text = "Solo letras y numeros";
                    txtuser.Refresh();
                    button1.Enabled = false;
                    button1.Refresh();
                }
                else
                {
                    txtuser.Text = "";
                    txtuser.Refresh();
                    txtuser.Hide();
                    //button1.Enabled = true;
                }
                if (Regex.IsMatch(pass, @"[^a-zA-Z0-9]"))
                {
                    txtpass.Show();
                    txtpass.Text = "Solo letras y numeros";
                    txtpass.Refresh();
                    button1.Enabled = false;
                    button1.Refresh();
                }
                else
                {
                    txtpass.Text = "";
                    txtpass.Refresh();
                    txtpass.Hide();
                    //button1.Enabled = true;
                }
                if (Regex.IsMatch(pass2, @"[^a-zA-Z0-9]"))
                {
                    txtpass2.Show();
                    txtpass2.Text = "Solo letras y numeros";
                    txtpass2.Refresh();
                    button1.Enabled = false;
                    button1.Refresh();
                }
                else
                {
                    txtpass2.Text = "";
                    txtpass2.Refresh();
                    txtpass2.Hide();
                    //button1.Enabled = true;
                }
            }
            else
            {
                //Reset
                txtuser.Text = "";
                txtuser.Refresh();
                txtuser.Hide();

                txtpass.Text = "";
                txtpass.Refresh();
                txtpass.Hide();

                txtpass2.Text = "";
                txtpass2.Refresh();
                txtpass2.Hide();

                button1.Enabled = true;
                button1.Refresh();
            }
        }
    }
}
