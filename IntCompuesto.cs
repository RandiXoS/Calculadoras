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
        int periodadding = 0, countperiod = 0, c = 0;
        double i = 0, ic = 0, it = 0, periodcapital = 0;

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
            i = (double)interest / 100;

            periodadding = 0;
            adding *= c;

            periodcapital = capitalinit;
            //ic = i * periodcapital;
            //Adding Rows

            for (int a = 0; a < plazo; a++)
            {
                //Numeros de pagos anualmente
                dataGridView1.Rows.Add();
                dataGridView1.Rows[a].Cells[0].Value = a + 1;

                //////Aportaciones
                periodadding += adding;
                dataGridView1.Rows[a].Cells[1].Value = periodadding;

                ////Interes
                ic = i * periodcapital;
                it += ic;
                
               
                dataGridView1.Rows[a].Cells[2].Value = it;

                //capital
                
                periodcapital += adding + ic;
                dataGridView1.Rows[a].Cells[3].Value = periodcapital;
            }
            label9.Text = (periodadding + capitalinit).ToString("N0");
            label10.Text = ((int)it).ToString("N0");
            label11.Text = ((int)periodcapital).ToString("N0");

            panel1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            countperiod = comboBox1.SelectedIndex;
            switch (countperiod)
            {
                case 0: c = 1;   break;
                case 1: c = 12;  break;
                default: break;
            }
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
            comboBox1.SelectedIndex = 0;
            
        }
    }
}
