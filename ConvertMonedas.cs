using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Calculadoras
{
    public partial class ConvertMonedas : Form
    {
        int c1 = 0, c2 = 0;
        int count1 = 0, count2 = 0;
        double v1;
        string []sismoneda = new string[] {"RD$", "USD", "€" };
        public ConvertMonedas()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            switch (c1)
            {
                case 0:
                    if (c2 == 1) 
                    { 
                        v1 = count1 * 0.0175335; 
                        textBox2.Text = decimal.Round((decimal)v1, 2) + ""; 
                    }
                    if (c2 == 2) 
                    {
                        v1 = count1 * 0.01477;
                        textBox2.Text = decimal.Round((decimal)v1, 2) + ""; 
                    }
                    break;

                case 1:
                    if (c2 == 0)
                    {
                        v1 = count1 * 57.14657;
                        textBox2.Text = decimal.Round((decimal)v1, 2) + "";
                    }
                    if (c2 == 2)
                    {
                        v1 = count1 * 0.84422575;
                        textBox2.Text = decimal.Round((decimal)v1, 2) + "";
                    }
                    break;

                case 2:
                    if (c2 == 0)
                    {
                        v1 = count1 * 67.7;
                        textBox2.Text = decimal.Round((decimal)v1, 2) + "";
                    }
                    if (c2 == 1)
                    {
                        v1 = count1 * 1.1845433;
                        textBox2.Text = decimal.Round((decimal)v1, 2) + "";
                    }
                    break;

                default:
                    break;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            c2 = comboBox2.SelectedIndex;
            if (c1 == c2) { textBox2.Text = textBox1.Text; }
            switch (c2)
            {
                case 0: label3.Text = sismoneda[c2]; break;
                case 1: label3.Text = sismoneda[c2]; break;
                case 2: label3.Text = sismoneda[c2]; break;

                default:
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out count1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out count2);
        }

        private void ConvertMonedas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Aux.scalc.Show();
        }

        private void ConvertMonedas_Load(object sender, EventArgs e)
        {
            timer1.Start();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1 = comboBox1.SelectedIndex;

            if (c1 == c2) { textBox2.Text = textBox1.Text; }
            switch (c1)
            {
                case 0: label2.Text = sismoneda[c1]; break;
                case 1: label2.Text = sismoneda[c1]; break;
                case 2: label2.Text = sismoneda[c1]; break;

                default:
                    break;
            }
        }
    }
}
