using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;
using HtmlAgilityPack;

namespace Calculadoras
{
    public partial class ConvertMonedas : Form
    {

        WebBrowser web = new WebBrowser();
        //Urls
        string[] urllist = new string[]
        {
            "https://cuex.com/es/dop-btc",
            "https://cuex.com/es/usd-btc",
            "https://cuex.com/es/eur-btc",
            "https://cuex.com/es/jpy-btc"
        };
        string[] saveurl = new string[6];
        
        //variables auxiliares
        int c1 = 0, c2 = 0, incr = 0;
        float count1 = 0, count2 = 0;
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
            float.TryParse(textBox1.Text, out count1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(textBox2.Text, out count2);
        }

        private void ConvertMonedas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Aux.scalc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void ConvertMonedas_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            //button1_Click(new object(), new EventArgs());
            //timer2.Start();
            timer1.Start();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            timer2.Stop();
            
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
