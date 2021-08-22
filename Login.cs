using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using SpreadsheetLight;

namespace Calculadoras
{

    public partial class Login : Form
    {

        string user = "", pass = "";
        int conf = 1;
        int trying = 3;

        
        public string fileLocation = @"C:\Users\Randi\Desktop\Bussiness\Calcv2.0\DataBase\Usuarios.xlsx";
        //string[] lista;
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
            textBox1.Focus();

            try
            {

                if (File.Exists(Aux.file))
                {
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Dejaste Campos vacíos", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SLDocument ls = new SLDocument(Aux.file);
                        

                        using (ls)
                        {

                            string[] datas = new string[] { user, pass };
                            int inc = 1;

                            for (int i = 1; i <= 2; i++)
                            {
                                inc = 1;
                                while (!string.IsNullOrEmpty(ls.GetCellValueAsString(inc, i)))
                                {
                                    if (datas[i - 1] == ls.GetCellValueAsString(inc, i))
                                    {
                                        conf++;
                                    }

                                    inc++;
                                }
                            }

                        }

                        //Iniciando
                        if (conf > 2)
                        {
                            trying = 0;
                            SelectCalc scalc = new SelectCalc();
                            MessageBox.Show("Ha Iniciado Sesion correctamente\n" +
                                "Bienvenido:    " + user, "Inicio Exitoso", MessageBoxButtons.OK, MessageBoxIcon.None);

                            textBox1.Text = "";
                            textBox2.Text = "";

                            Hide();
                            scalc.Show();
                        }
                        else
                        {
                            if (trying <= 1)
                            {
                                trying = 0;
                                MessageBox.Show("Ha superado el numero Maximo de intentos", "Exiting...", MessageBoxButtons.OK,
                                                                            MessageBoxIcon.Information);
                                button1.Enabled = false;
                                textBox1.Enabled = false;
                                textBox2.Enabled = false;
                            }
                            else
                            {
                                trying--;
                                MessageBox.Show("Usuario o Contraseña Incorrectos.", "Error", MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                                MessageBox.Show("le quedan " + trying + " Intentos.", "Aviso", MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                
                //Reseteando textbox
                textBox1.Text = "";
                textBox2.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontró la Base de Datos, reinicie la app para crear otra.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

            timer1.Start();
           
            if(!File.Exists(Aux.file))
                {
                    //MessageBox.Show("No se encontró la Base de Datos\n" +"Creando una.....");

                    SLDocument doc = new SLDocument();


                    doc.SetCellValue(1, 1, "Usernames");
                    doc.SetCellValue(1, 2, "Password");
                    doc.SetCellValue(2, 1, "user");
                    doc.SetCellValue(2, 2, "1234");
                    //Aplicando Estilos
                    SLStyle style1 = new SLStyle();
                    SLStyle style2 = new SLStyle();



                    SLBorder lBorder = new SLBorder();

                    style1.SetFont("Times New Romans", 16);
                    style2.SetFont("Times New Romans", 14);

                    style1.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
                    style1.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
                    style1.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
                    style1.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;

                    style2.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
                    style2.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
                    style2.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
                    style2.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;



                    style1.SetHorizontalAlignment(DocumentFormat.OpenXml.Spreadsheet.HorizontalAlignmentValues.Center);
                    style1.SetVerticalAlignment(DocumentFormat.OpenXml.Spreadsheet.VerticalAlignmentValues.Center);
                    style2.SetHorizontalAlignment(DocumentFormat.OpenXml.Spreadsheet.HorizontalAlignmentValues.Center);

                    style1.SetFontBold(true);

                    style1.SetPatternFill(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid,
                        ForegroundColor: System.Drawing.Color.ForestGreen,
                        BackgroundColor: System.Drawing.Color.Black);

                    style2.SetPatternFill(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid,
                       ForegroundColor: System.Drawing.Color.FromArgb(156, 195, 248),
                       BackgroundColor: System.Drawing.Color.White);

                    doc.SetColumnWidth(1, 2, 85);
                    doc.SetRowHeight(1, 30);
                    doc.SetCellStyle(1, 1, 1, 2, style1);
                    doc.SetCellStyle(2, 1, 200, 2, style2);
                //Finalizando Estilos

                //Guardando

                if (!File.Exists(Directory.GetCurrentDirectory() + @"\DataBase"))
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\DataBase"); 
                }
                
                
                doc.SaveAs(Aux.file);
            }

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ((char)Keys.Enter))
            {
                button1_Click(new object(), new EventArgs());
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                button1_Click(new object(), new EventArgs());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pass = textBox2.Text;
        }
    }
}
