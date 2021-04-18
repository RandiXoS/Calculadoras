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
        float cuota = 0;
        public Tabla_CalcPres()
        {
            InitializeComponent();
        }
        
        
        private void Tabla_CalcPres_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            int count = 0;
            float saldo;


            DatosTabla.Rows.Add(InfoTable.readTime-1);

            float auxcuota = (float)InfoTable.readAmount / InfoTable.readTime;

            for (int i = 1; i <= InfoTable.readTime; i++)
            {
                
            }
            //Bucle para mostrar Información
            for (int i = 1; i <= InfoTable.readTime; i++)
            {
                DatosTabla.Rows[count].Cells[0].Value = i;
                DatosTabla.Rows[count].Cells[1].Value = decimal.Round((decimal)cuota,1);

                count++;
            }
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
