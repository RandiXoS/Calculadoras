using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoras
{
    public partial class SelectCalc : Form
    {
        

        //Creando objetos de sus respectivas clases para llamar los formularios
       
        
        
        
        
        public SelectCalc()
        {
            InitializeComponent();
            
        }

        public void Main_Load(object sender, EventArgs e)
        {
            Aux.scalc = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntCompuesto intCompuesto = new IntCompuesto();
            Hide();
            intCompuesto.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaldoInsoluto saldoInsoluto = new SaldoInsoluto();
            Hide();
            saldoInsoluto.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Deuda deuda = new Deuda();
            Hide();
            deuda.Show(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ahorro ahorro = new Ahorro();
            Hide();
            ahorro.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConvertMonedas cmonedas = new ConvertMonedas();
            Hide();
            cmonedas.Show();
        }

        private void SelectCalc_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
        }
    }
}
