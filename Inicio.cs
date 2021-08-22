using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Calculadoras
{
    public partial class Inicio : Form
    {
        //int x = 0;
        static WebBrowser web = new WebBrowser();
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 50; i+=2)
            {
                progressBar1.Value = i;
                label1.Text = i + "%";
                label1.Refresh();

                Thread.Sleep(10);
            }

            ConvertMonedas monedas = new ConvertMonedas();
            Thread.Sleep(500);
            monedas.Show();
            timer1.Stop();
        }
    }
}
