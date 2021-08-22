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
    public partial class SignUp : Form
    {
        string user = "", pass = "", pass2 = "";
        public SignUp()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            pass = textBox3.Text;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            user = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pass2 = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Evitando que los campos esten vacios

            //Comprobando que las contraseñas sean iguales
            if (File.Exists(Aux.file))
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Dejaste Campos vacíos", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (pass == pass2)
                    {
                        //-------------------------Codigo para Ingresar al Excel---------------------



                        int inc = 1;//Cuenta los numeros de usuarios para poder agregar otro

                        //Abriendo Excel creado y sobreescribiendolo en otro nuevo
                        //Para poder guardarlo
                        SLDocument ls = new SLDocument(Aux.file);
                        SLDocument doc = new SLDocument();


                        for (int i = 1; i < 3; i++)
                        {
                            inc = 1;

                            while (!string.IsNullOrEmpty(ls.GetCellValueAsString(inc, i)))
                            {
                                doc.SetCellValue(inc, i, ls.GetCellValueAsString(inc, i));

                                inc++;
                            }
                        }
                        doc.SetCellValue(inc, 1, user);
                        doc.SetCellValue(inc, 2, pass);

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
                        doc.SaveAs(Aux.file);

                        MessageBox.Show("Se ha registrado correctamente", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha encontrado la Base de Datos, reinicie la app para crear uno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                button1_Click(new object(), new EventArgs());
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
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

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Login login = new Login();
            login.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Regex.IsMatch(user, @"[^a-zA-Z0-9]") || Regex.IsMatch(pass, @"[^a-zA-Z0-9]") || Regex.IsMatch(pass2, @"[^a-zA-Z0-9]"))
            {
                if (Regex.IsMatch(user, @"[^a-zA-Z0-9]"))
                {
                    txtuser.Show();
                    txtuser.Text = "Solo letras y numeros";
                    txtuser.Refresh();
                    button1.Enabled = false;
                    button1.Refresh();
                }
                else
                {
                    txtuser.Text = "";
                    txtuser.Refresh();
                    txtuser.Hide();
                    //button1.Enabled = true;
                }
                if (Regex.IsMatch(pass, @"[^a-zA-Z0-9]"))
                {
                    txtpass.Show();
                    txtpass.Text = "Solo letras y numeros";
                    txtpass.Refresh();
                    button1.Enabled = false;
                    button1.Refresh();
                }
                else
                {
                    txtpass.Text = "";
                    txtpass.Refresh();
                    txtpass.Hide();
                    //button1.Enabled = true;
                }
                if (Regex.IsMatch(pass2, @"[^a-zA-Z0-9]"))
                {
                    txtpass2.Show();
                    txtpass2.Text = "Solo letras y numeros";
                    txtpass2.Refresh();
                    button1.Enabled = false;
                    button1.Refresh();
                }
                else
                {
                    txtpass2.Text = "";
                    txtpass2.Refresh();
                    txtpass2.Hide();
                    //button1.Enabled = true;
                }
            }
            else
            {
                //Reset
                txtuser.Text = "";
                txtuser.Refresh();
                txtuser.Hide();

                txtpass.Text = "";
                txtpass.Refresh();
                txtpass.Hide();

                txtpass2.Text = "";
                txtpass2.Refresh();
                txtpass2.Hide();

                button1.Enabled = true;
                button1.Refresh();
            }
        }
    }
}
