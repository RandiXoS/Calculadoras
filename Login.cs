using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
//using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
//using SpreadsheetLight;

namespace Calculadoras
{

    public partial class Login : Form
    {

        string user = "", pass = "", readexcel = " ";
        bool c1 = true, c2 = true;

        int i = 2;
        //Excell.Application appExcel = new Excell.Application();
        public string fileLocation =
            @"C:\Users\Randi\Desktop\Bussiness\Calcv2.0\DataBase\Usuarios.xlsx";
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            SignUp registro = new SignUp();
            Hide();
            registro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SelectCalc scalc = new SelectCalc();
            //Hide();
            //scalc.Show();
            //var appExcel = new Excell.Application();


            if (File.Exists(fileLocation))
            {
                //SLDocument excel = new SLDocument(fileLocation);
                //using (excel)
                //{
                //    List<string> l = excel.GetSheetNames();
                //    textBox1.Text = l[0].Length + "";
                //}
                //Workbook workbook = appExcel.Workbooks.Open(fileLocation);
                //Worksheet sheetexcel = (Worksheet)workbook.Sheets[1];
                ////workbook.Close();

                ////verificando usuario con el excel
                //while (c1)
                //{
                //    if (string.IsNullOrEmpty(((Excell.Range)sheetexcel.Cells[i, 1]).Value.ToString()))
                //    {

                //        readexcel = ((Excell.Range)sheetexcel.Cells[i, 1]).Value.ToString();
                //        if (user == readexcel)
                //        {
                //            c1 = false;
                //            i = 0;
                //            break;

                //        }
                //        i++;
                //    }
                //}
                ////Verficando password con el excel
                //while (c2)
                //{

                //    if (!string.IsNullOrEmpty(((Excell.Range)sheetexcel.Cells[i, 2]).Value.ToString()))
                //    {
                //        readexcel = ((Excell.Range)sheetexcel.Cells[i, 2]).Value.ToString();
                //        if (pass == readexcel)
                //        {
                //            c2 = false;
                //            i = 0;
                //            break;
                //        }
                //        i++;
                //    }

                //}

                //if (!c1 && !c2)
                //{
                //    MessageBox.Show("Bienvenido" + user, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    SelectCalc scalc = new SelectCalc();
                //    Hide();
                //    scalc.Show();
                //}
                //else
                //{
                //    c1 = true;
                //    c2 = true;
                //    i = 0;
                //    readexcel = " ";
                //    MessageBox.Show("Usuario o Contraseña Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            else
            {
                MessageBox.Show("No se ha encontrado la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //sheetexcel.Cells[4, 1] = "Ada";
            //sheetexcel.Cells[4, 2] = "Rosa";
            //textBox1.Text = ((Excell.Range)sheetexcel.Cells[2, 1]).Value.ToString();
            //textBox2.Text = ((Excell.Range)sheetexcel.Cells[2, 2]).Value.ToString();

            //sheetexcel.SaveAs2(fileLocation);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Regex.IsMatch(user, @"[^a-zA-Z0-9]") || Regex.IsMatch(pass, @"[^a-zA-Z0-9]"))
            {
                if (Regex.IsMatch(user, @"[^a-zA-Z0-9]"))
                {
                    label4.Show();
                    label4.Text = "Solo letras y numeros";
                    label4.Refresh();
                    button1.Enabled = false;
                    button1.Refresh();
                }
                else
                {
                    label4.Text = "";
                    label4.Refresh();
                    label4.Hide();
                    //button1.Enabled = true;
                }
                if (Regex.IsMatch(pass, @"[^a-zA-Z0-9]"))
                {
                    label5.Show();
                    label5.Text = "Solo letras y numeros";
                    label5.Refresh();
                    button1.Enabled = false;
                    button1.Refresh();
                }
                else
                {
                    label5.Text = "";
                    label5.Refresh();
                    label5.Hide();
                    //button1.Enabled = true;
                }
            }
            else
            {
                //Reset
                label4.Text = "";
                label4.Refresh();
                label4.Hide();

                label5.Text = "";
                label5.Refresh();
                label5.Hide();

                button1.Enabled = true;
                button1.Refresh();
            }
        }

        private void label5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            user = textBox1.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pass = textBox2.Text;

        }
    }
}
