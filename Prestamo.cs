using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SpreadsheetLight;
using System.Text.RegularExpressions;

namespace Calculadoras
{
    public partial class Prestamo : Form
    {
        delegate void listchangedindex(object s, EventArgs a);

        int save_list = 2;
        int s = 0;
        string nombre = "", fecha = "", hora = "";
        int amount = 0;
        DateTime time = new DateTime();
        public Prestamo()
        {
            InitializeComponent();
        }

        private void Prestamo_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prestamo_Load_1(object sender, EventArgs e)
        {
            //abonar_button.Enabled = false;
            timer1.Start();

            if (!File.Exists(Directory.GetCurrentDirectory() + @"\DataBase\Usuarios_Deuda\Prestamos.xlsx"))
            {
                //MessageBox.Show("No se encontró la Base de Datos\n" +"Creando una.....");
                //richTextBox1.Text = "Entro al if del archivo";
                SLDocument doc = new SLDocument();


                doc.SetCellValue(1, 1, "Nombre");
                doc.SetCellValue(1, 2, "Cantidad a Pagar");
                doc.SetCellValue(1, 3, "Fecha de Préstamo");
                doc.SetCellValue(1, 4, "Hora");
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

                doc.SetColumnWidth(1, 4, 30);
                doc.SetRowHeight(1, 20);
                doc.SetCellStyle(1, 1, 1, 4, style1);
                doc.SetCellStyle(2, 1, 200, 4, style2);
                //Finalizando Estilos

                //Guardando

                if (!File.Exists(Directory.GetCurrentDirectory() + @"\DataBase\Usuarios_Deuda"))
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\DataBase\Usuarios_Deuda");
                }


                doc.SaveAs(Directory.GetCurrentDirectory() + @"\DataBase\Usuarios_Deuda\Prestamos.xlsx");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //user = textBox1.Text;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            //amount = int.Parse(textBox2.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"[^a-zA-Z0-9]") || Regex.IsMatch(textBox2.Text, @"[^0-9]"))
            {
                if (Regex.IsMatch(textBox1.Text, @"[^a-zA-Z0-9]"))
                {
                    label_usu.Show();
                    label_usu.Text = "Sólo letras y numeros";
                    label_usu.Refresh();
                    button1.Enabled = false;
                    button1.Refresh();
                }
                else
                {
                    label_usu.Text = "";
                    label_usu.Refresh();
                    label_usu.Hide();
                    //button1.Enabled = true;
                }
                if (Regex.IsMatch(textBox2.Text, @"[^0-9]"))
                {
                    label_money.Show();
                    label_money.Text = "Sólo numeros";
                    label_money.Refresh();
                    button1.Enabled = false;
                    button1.Refresh();
                }
                else
                {
                    label_money.Text = "";
                    label_money.Hide();
                    label_money.Refresh();
                    //button1.Enabled = true;
                }
            }
            else
            {
                //Reset
                label_usu.Text = "";
                label_usu.Refresh();
                label_usu.Hide();
                label_money.Text = "";
                label_money.Refresh();
                label_money.Hide();

                button1.Enabled = true;
                button1.Refresh();

            }

            if (Regex.IsMatch(textBox3.Text, @"[^0-9]"))
            {
                abonar_button.Enabled = false;
                abonar_button.Refresh();
                label10.Show();
                label10.Text = "Sólo numeros";
                label10.Refresh();
            }
            //else if (textBox3.Text == "")
            //{
            //    abonar_button.Enabled = false;
            //    label10.Hide();
            //    //label10.Text = "";
            //    label10.Refresh();
            //}
            else
            {
                //Reset
                label10.Hide();
                //label10.Text = "";
                label10.Refresh();

                abonar_button.Enabled = true;
                abonar_button.Refresh();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int inc = 2;//Cuenta los numeros de usuarios para poder agregar otro

            //Abriendo Excel creado y sobreescribiendolo en otro nuevo
            //Para poder guardarlo
            SLDocument ls = new SLDocument(Directory.GetCurrentDirectory() + @"\DataBase\Usuarios_Deuda\Prestamos.xlsx");
            while (!string.IsNullOrEmpty(ls.GetCellValueAsString(inc, 1)))
            {
                //listBox1.Items.Add(ls.GetCellValueAsString(inc, 1));
                inc++;
            }
            if (save_list < inc)
            {
                while (!string.IsNullOrEmpty(ls.GetCellValueAsString(save_list, 1)))
                {
                    listBox1.Items.Add(ls.GetCellValueAsString(save_list, 1));
                    save_list++;
                }
            }
            
        }

        private void abonar_button_Click(object sender, EventArgs e)
        {
            int select = 0;
            bool ready = false;
            listchangedindex l = new listchangedindex(listBox1_SelectedIndexChanged);
            if (textBox3.Text == "")
            {
                MessageBox.Show("Dejaste el campo vacío.", "Error", MessageBoxButtons.OK,  MessageBoxIcon.Information);

            }
            else
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (listBox1.GetSelected(i))
                    {
                        select = i;
                        ready = true;
                    }
                }
                if (ready)
                {
                    //Código para abonar
                    
                    int inc = 2;//Cuenta los numeros de usuarios para poder agregar otro

                    //Abriendo Excel creado y sobreescribiendolo en otro nuevo
                    //Para poder guardarlo
                    SLDocument ls = new SLDocument(Directory.GetCurrentDirectory() + @"\DataBase\Usuarios_Deuda\Prestamos.xlsx");
                    SLDocument doc = new SLDocument();


                    for (int i = 1; i < 5; i++)
                    {
                        inc = 2;

                        while (!string.IsNullOrEmpty(ls.GetCellValueAsString(inc, i)))
                        {
                            doc.SetCellValue(inc, i, ls.GetCellValueAsString(inc, i));

                            inc++;
                        }
                    }

                    int leermonto = int.Parse(textBox3.Text);
                    string leerdeuda = ls.GetCellValueAsString(s + 2, 2);
                    string[] array = leerdeuda.Split(',', StringSplitOptions.RemoveEmptyEntries);
                    string sum = "";
                    foreach (var item in array)
                    {
                        sum += item;
                    }
                    int t = int.Parse(sum) - leermonto;

                    if (t < 0)
                    {
                        t = 0;
                    }
                    doc.SetCellValue(s + 2, 2, t.ToString("N0"));

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

                    doc.SetColumnWidth(1, 4, 30);
                    doc.SetRowHeight(1, 20);
                    doc.SetCellStyle(1, 1, 1, 4, style1);
                    doc.SetCellStyle(2, 1, 200, 4, style2);
                    //Finalizando Estilos

                    //Guardando
                    
                    doc.SaveAs(Directory.GetCurrentDirectory() + @"\DataBase\Usuarios_Deuda\Prestamos.xlsx");
                    l.Invoke(new object(), new EventArgs());
                }
                else
                {
                    MessageBox.Show("Seleccione la persona que abonará", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SLDocument excel = new SLDocument(Directory.GetCurrentDirectory() + @"\DataBase\Usuarios_Deuda\Prestamos.xlsx");
            s = listBox1.SelectedIndex;
            

            labelnombre.Text = listBox1.Items[s].ToString();
            labeldeuda.Text = excel.GetCellValueAsString(s + 2, 2);
            labelfecha.Text = excel.GetCellValueAsString(s + 2, 3);
            labelhora.Text = excel.GetCellValueAsString(s + 2, 4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IFormatProvider language = new System.Globalization.CultureInfo("es-ES");

            nombre = textBox1.Text;
            amount = int.Parse(textBox2.Text);
            time = DateTime.Now;

            string[] l = time.GetDateTimeFormats('m', language);
            string[] t = time.GetDateTimeFormats('t');

            fecha = string.Format("{0} {1}", l[0], time.Year);
            hora = string.Format("{0}", t[0]);
            
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Dejaste Campos vacíos", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int inc = 1;//Cuenta los numeros de usuarios para poder agregar otro

                //Abriendo Excel creado y sobreescribiendolo en otro nuevo
                //Para poder guardarlo
                SLDocument ls = new SLDocument(Directory.GetCurrentDirectory() + @"\DataBase\Usuarios_Deuda\Prestamos.xlsx");
                SLDocument doc = new SLDocument();


                for (int i = 1; i < 5; i++)
                {
                    inc = 1;

                    while (!string.IsNullOrEmpty(ls.GetCellValueAsString(inc, i)))
                    {
                        doc.SetCellValue(inc, i, ls.GetCellValueAsString(inc, i));

                        inc++;
                    }
                }
                
                doc.SetCellValue(inc, 1, nombre);
                doc.SetCellValue(inc, 2, amount.ToString("N0"));
                doc.SetCellValue(inc, 3, fecha);
                doc.SetCellValue(inc, 4, hora);

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

                doc.SetColumnWidth(1, 4, 30);
                doc.SetRowHeight(1, 20);
                doc.SetCellStyle(1, 1, 1, 4, style1);
                doc.SetCellStyle(2, 1, 200, 4, style2);
                //Finalizando Estilos

                //Guardando
                doc.SaveAs(Directory.GetCurrentDirectory() + @"\DataBase\Usuarios_Deuda\Prestamos.xlsx");

                MessageBox.Show("Se ha registrado correctamente", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            //Boton b = new Boton(button2_Click);
            button2_Click(new object(), new EventArgs());
        }
    }
}
