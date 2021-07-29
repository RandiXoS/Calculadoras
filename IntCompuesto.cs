using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadoras
{
    public partial class IntCompuesto : Form
    {
        int capitalinit = 0, adding = 0, plazo = 0, interest = 0;
        int period_adding = 0;
        double i = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out capitalinit);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out adding);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plazo = (int)numericUpDown1.Value;
            interest = (int)numericUpDown2.Value;
            i = interest / 100;
        }

        public IntCompuesto()
        {
            InitializeComponent();
           
        }

        private void IntCompuesto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Aux.scalc.Show();
            
        }

        private void IntCompuesto_Load(object sender, EventArgs e)
        {
            
        }
    }
}
