using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadoras
{
   
    public partial class SaldoInsoluto : Form
    {
        int amount, years, month, interest;
        public SaldoInsoluto()
        {
            InitializeComponent();
        }

        private void SaldoInsoluto_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Saving the amount
            int.TryParse(textBox1.Text, out amount);
            InfoTable.readAmount = amount;

            //Saving months
            int.TryParse(textBox3.Text, out month);

            //Converting years to months
            int.TryParse(textBox2.Text, out years);
            years *= 12;

            //Adding all months
            InfoTable.readTime = years + month;

            //Converting number to decimal for the interest
            int.TryParse(textBox4.Text, out interest);
            InfoTable.readInterest = (float)interest / 100;

            //Opening new form for show the information
            
            Tabla_CalcPres tabla = new Tabla_CalcPres();
            tabla.Show();
            
            

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void SaldoInsoluto_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
