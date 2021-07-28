using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadoras
{
    public partial class Tabla_CalcPres : Form
    {
        double cuota = 0;
        double i = 0, it = 0;
        float p = 0;
        double c = 0;
        public Tabla_CalcPres()
        {
            InitializeComponent();
        }
        
        
        private void Tabla_CalcPres_Load(object sender, EventArgs e)
        {
            
            //timer1.Start();
            int count = 0;

            i = InfoTable.readInterest;
            p = InfoTable.readTime;
            c = InfoTable.readAmount;
            double auxi = 0;

            DatosTabla.Rows.Add((int)p - 1);

            //float auxcuota = (float)InfoTable.readAmount / InfoTable.readTime;
            cuota = InfoTable.readAmount * ((Math.Pow((1 + i), p) * i) / (Math.Pow((1 + i), p) - 1));
            
            //Bucle para mostrar Información
            for (int i1 = 1; i1 <= p; i1++)
            {
                DatosTabla.Rows[count].Cells[0].Value = i1;
                DatosTabla.Rows[count].Cells[1].Value = ((int)cuota).ToString("N0") + " $";
                auxi = i * c;
                it += auxi;
                DatosTabla.Rows[count].Cells[2].Value = ((int)auxi).ToString("N0") + " $";
                c = c - (cuota - Convert.ToDouble(auxi));
                DatosTabla.Rows[count].Cells[3].Value = ((int)c).ToString("N0") + " $";

                count++;
            }
            tmonto.Text = InfoTable.readAmount.ToString("N0") + " $";
            tint.Text = ((int)it).ToString("N0") + " $";
            tmontofinal.Text = ((int)(cuota * p)).ToString("N0") + " $";
            panel1.Show();
        }
        private void tabla_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
