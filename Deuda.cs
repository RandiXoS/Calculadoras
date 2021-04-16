using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadoras
{
    public partial class Deuda : Form
    {
        //Leen la información en los textbox
        int readcapital = 0, readinteres = 0, readperiodo = 0;

        //Hacen de contadores para saber en que posición están
        //los combobox
        int countInteres = 0, countPeriodo = 0;
        float countPago = 0;

        //variables auxiliares
        float I = 0;//almacena el interes en decimal
        decimal CF;
        int P;
        decimal pagofinal, CI;
        int opcinteres, opcperiodo, opcpago;

        //Funcion que resetea todo
        private void Resetear()
        {
            textCapital.Text = "0";
            textInteres.Text = "0";
            textPeriodo.Text = "0";

            SelectInteres.SelectedIndex = -1;
            SelectPeriodo.SelectedIndex = -1;
            SelectPago.SelectedIndex = -1;

            richTextBox1.Hide();
        }


        
        private void textInteres_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textInteres.Text, out readinteres);
            I = (float)readinteres / 100;
            
        }

        private void textPeriodo_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textPeriodo.Text, out readperiodo);
        }

        private void Deuda_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Resetear();
            
        }

        private void SelectInteres_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            0- Semanal
            1- Quincenal
            2- Mensual
            3- Anual
             */
            opcinteres = SelectInteres.SelectedIndex;
            
            switch(opcinteres)
            {
                case 0: countInteres = 7; break;
                case 1: countInteres = 15; break;
                case 2: countInteres = 30; break;
                case 3: countInteres = 365; break;
            }
        }

        private void SelectPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            0- Semanal
            1- Quincenal
            2- Mensual
            3- Anual
             */
            opcperiodo = SelectPeriodo.SelectedIndex;

            switch (opcperiodo)
            {
                case 0: countPeriodo = 7; break;
                case 1: countPeriodo = 15; break;
                case 2: countPeriodo = 30; break;
                case 3: countPeriodo = 365; break;
            }
        }

        private void SelectPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            0- Diario
            1- Interdiario
            2- Semanal
            3- Quincenal
            4- Mensual
            5- Anual
             */
            opcpago = SelectPago.SelectedIndex;

            switch (opcpago)
            {
                case 0: countPago = 1; break;
                case 1: countPago = 2; break;
                case 2: countPago = 7; break;
                case 3: countPago = 15; break;
                case 4: countPago = 30; break;
                case 5: countPago = 365; break;

            }
        }

        public void Deuda_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resetear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (opcinteres > opcperiodo) { SelectInteres.SelectedIndex -= 1; }
            if (opcpago > opcperiodo + 2) { SelectPago.SelectedIndex -= 1; }
        }

        private void textCapital_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textCapital.Text, out readcapital);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            P = (readperiodo * countPeriodo) / countInteres;
            CI = readcapital;
            //resuelve problema al dividir 365/30
            if (readperiodo == 12 && opcperiodo == 2) { P++; }

            CF = CI * Convert.ToDecimal((P * I)) + CI;
            pagofinal = CF / (Convert.ToDecimal((countPeriodo/countPago)));


            richTextBox1.Show();
            richTextBox1.Text = "Capital Final: " + (int)CF + "\n";
            richTextBox1.Text += "Pago(s): " + decimal.Round(pagofinal, 2) + "\n";
        }

        public Deuda()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
