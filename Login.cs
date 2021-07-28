using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadoras
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp registro = new SignUp();
            Hide();
            registro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectCalc scalc = new SelectCalc();
            Hide();
            scalc.Show();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
