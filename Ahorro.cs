using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadoras
{
    public partial class Ahorro : Form
    {
        int amount = 0, plazo = 0, p = 0;
        int opcperiodo = 0, opcperiodometa = 0, countPeriodo, countMeta = 0;
        public Ahorro()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcperiodometa = comboBox2.SelectedIndex;

            switch (opcperiodometa)
            {
                case 0: countMeta = 1; break;
                case 1: countMeta = 2; break;
                case 2: countMeta = 7; break;
                case 3: countMeta = 15; break;
                case 4: countMeta = 30; break;
                case 5: countMeta = 365; break;
            }
        }

        private void Ahorro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Aux.scalc.Show();
        }

        private void Ahorro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out amount);
            int.TryParse(textBox2.Text, out plazo);
            plazo *= countPeriodo; //Converting the period to days
            p = plazo / countMeta;
            label5.Text = (amount / p).ToString("N0");

            panel1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcperiodo = comboBox1.SelectedIndex;

            switch (opcperiodo)
            {
                case 0: countPeriodo = 7; break;
                case 1: countPeriodo = 15; break;
                case 2: countPeriodo = 30; break;
                case 3: countPeriodo = 365; break;
            }
        }
    }
}
