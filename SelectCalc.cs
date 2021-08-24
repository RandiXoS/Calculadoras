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
        
        public SelectCalc()
        {
            InitializeComponent();
            
        }

        public void Main_Load(object sender, EventArgs e)
        {
            picture_ahorro.Cursor = Cursors.Hand;
            picture_compuesto.Cursor = Cursors.Hand;
            pictur_monedas.Cursor = Cursors.Hand;
            picture_saldo.Cursor = Cursors.Hand;
            picture_prestamos.Cursor = Cursors.Hand;

            label2.Cursor = Cursors.Hand;
            label3.Cursor = Cursors.Hand;
            label4.Cursor = Cursors.Hand;
            label5.Cursor = Cursors.Hand;
            label6.Cursor = Cursors.Hand;



            Aux.scalc = this;
        }

        private void picture_ahorro_Click(object sender, EventArgs e)
        {
            Ahorro ahorro = new Ahorro();
            Hide();
            ahorro.Show();
        }
        private void picture_compuesto_Click(object sender, EventArgs e)
        {
            IntCompuesto intCompuesto = new IntCompuesto();
            Hide();
            intCompuesto.Show();
        }
        private void picture_moneda_Click(object sender, EventArgs e)
        {
            ConvertMonedas cmonedas = new ConvertMonedas();
            Hide();
            cmonedas.Show();
        }
        private void picture_saldo_Click(object sender, EventArgs e)
        {
            SaldoInsoluto saldoInsoluto = new SaldoInsoluto();
            Hide();
            saldoInsoluto.Show();
        }
        private void picture_prestamo_Click(object sender, EventArgs e)
        {
            Deuda deuda = new Deuda();
            Hide();
            deuda.Show();
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

        private void picture_compuesto_MouseEnter(object sender, EventArgs e)
        {
            
            panel1.BorderStyle = BorderStyle.FixedSingle;
            //panel1.BackColor = Color.DarkGoldenrod;
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Refresh();
        }
        private void picture_compuesto_MouseLeave(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.None;
            panel1.BackColor = Color.Transparent;
            panel1.Refresh();
        }
        private void label4_MouseEnter(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.FixedSingle;
            //panel1.BackColor = Color.DarkGoldenrod;
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Refresh();
        }
        private void label4_MouseLeave(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.None;
            panel1.BackColor = Color.Transparent;
            panel1.Refresh();
        }

        private void picture_ahorro_MouseEnter(object sender, EventArgs e)
        {
            panel2.BorderStyle = BorderStyle.FixedSingle;
            //panel1.BackColor = Color.DarkGoldenrod;
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Refresh();
        }
        private void picture_ahorro_MouseLeave(object sender, EventArgs e)
        {
            panel2.BorderStyle = BorderStyle.None;
            panel2.BackColor = Color.Transparent;
            panel2.Refresh();
        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BorderStyle = BorderStyle.FixedSingle;
            //panel1.BackColor = Color.DarkGoldenrod;
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Refresh();
        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BorderStyle = BorderStyle.None;
            panel2.BackColor = Color.Transparent;
            panel2.Refresh();
        }

        private void pictur_monedas_MouseEnter(object sender, EventArgs e)
        {
            panel3.BorderStyle = BorderStyle.FixedSingle;
            //panel1.BackColor = Color.DarkGoldenrod;
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Refresh();
        }
        private void pictur_monedas_MouseLeave(object sender, EventArgs e)
        {
            panel3.BorderStyle = BorderStyle.None;
            panel3.BackColor = Color.Transparent;
            panel3.Refresh();
        }
        private void label5_MouseEnter(object sender, EventArgs e)
        {
            panel3.BorderStyle = BorderStyle.FixedSingle;
            //panel1.BackColor = Color.DarkGoldenrod;
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Refresh();
        }
        private void label5_MouseLeave(object sender, EventArgs e)
        {
            panel3.BorderStyle = BorderStyle.None;
            panel3.BackColor = Color.Transparent;
            panel3.Refresh();
        }

        private void picture_prestamos_MouseEnter(object sender, EventArgs e)
        {
            panel4.BorderStyle = BorderStyle.FixedSingle;
            //panel1.BackColor = Color.DarkGoldenrod;
            panel4.BackColor = Color.DarkSlateGray;
            panel4.Refresh();
        }
        private void picture_prestamos_MouseLeave(object sender, EventArgs e)
        {
            panel4.BorderStyle = BorderStyle.None;
            panel4.BackColor = Color.Transparent;
            panel4.Refresh();
        }
        private void label6_MouseEnter(object sender, EventArgs e)
        {
            panel4.BorderStyle = BorderStyle.FixedSingle;
            //panel1.BackColor = Color.DarkGoldenrod;
            panel4.BackColor = Color.DarkSlateGray;
            panel4.Refresh();
        }
        private void label6_MouseLeave(object sender, EventArgs e)
        {
            panel4.BorderStyle = BorderStyle.None;
            panel4.BackColor = Color.Transparent;
            panel4.Refresh();
        }

        private void picture_saldo_MouseEnter(object sender, EventArgs e)
        {
            panel5.BorderStyle = BorderStyle.FixedSingle;
            //panel1.BackColor = Color.DarkGoldenrod;
            panel5.BackColor = Color.DarkSlateGray;
            panel5.Refresh();
        }
        private void picture_saldo_MouseLeave(object sender, EventArgs e)
        {
            panel5.BorderStyle = BorderStyle.None;
            panel5.BackColor = Color.Transparent;
            panel5.Refresh();
        }
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            panel5.BorderStyle = BorderStyle.FixedSingle;
            //panel1.BackColor = Color.DarkGoldenrod;
            panel5.BackColor = Color.DarkSlateGray;
            panel5.Refresh();
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            panel5.BorderStyle = BorderStyle.None;
            panel5.BackColor = Color.Transparent;
            panel5.Refresh();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            Hide();
            prestamo.Show();
        }
    }
}
