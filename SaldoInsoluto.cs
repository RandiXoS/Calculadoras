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
        int amount, years, mounth, interest;
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
            richTextBox1.Text = InfoTable.readInterest + "";

            //Definiendo años y meses
            InfoTable.readTime = years + mounth;

            //////
            Tabla_CalcPres tabla = new Tabla_CalcPres();
            tabla.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out amount);
            InfoTable.readAmount = amount;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out years);
            years *= 12;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out mounth);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox4.Text, out interest);
            InfoTable.readInterest = (float)interest / 100;
        }
    }
}
