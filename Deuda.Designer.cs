
namespace Calculadoras
{
    partial class Deuda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textCapital = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectInteres = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textInteres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPeriodo = new System.Windows.Forms.TextBox();
            this.SelectPeriodo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capital:";
            // 
            // textCapital
            // 
            this.textCapital.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textCapital.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCapital.Location = new System.Drawing.Point(86, 16);
            this.textCapital.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textCapital.Name = "textCapital";
            this.textCapital.Size = new System.Drawing.Size(258, 27);
            this.textCapital.TabIndex = 1;
            this.textCapital.Text = "0";
            this.textCapital.TextChanged += new System.EventHandler(this.textCapital_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.PeachPuff;
            this.label2.Location = new System.Drawing.Point(11, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interés:";
            // 
            // SelectInteres
            // 
            this.SelectInteres.BackColor = System.Drawing.Color.Lavender;
            this.SelectInteres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectInteres.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectInteres.FormattingEnabled = true;
            this.SelectInteres.Items.AddRange(new object[] {
            "Semanal",
            "Quincenal",
            "Mensual",
            "Anual"});
            this.SelectInteres.Location = new System.Drawing.Point(86, 76);
            this.SelectInteres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectInteres.Name = "SelectInteres";
            this.SelectInteres.Size = new System.Drawing.Size(118, 28);
            this.SelectInteres.TabIndex = 4;
            this.SelectInteres.SelectedIndexChanged += new System.EventHandler(this.SelectInteres_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Lavender;
            this.button1.Location = new System.Drawing.Point(242, 187);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textInteres
            // 
            this.textInteres.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textInteres.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textInteres.Location = new System.Drawing.Point(231, 77);
            this.textInteres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textInteres.Name = "textInteres";
            this.textInteres.Size = new System.Drawing.Size(113, 27);
            this.textInteres.TabIndex = 2;
            this.textInteres.Text = "0";
            this.textInteres.TextChanged += new System.EventHandler(this.textInteres_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(350, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "%";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textPeriodo
            // 
            this.textPeriodo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textPeriodo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textPeriodo.Location = new System.Drawing.Point(231, 135);
            this.textPeriodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPeriodo.Name = "textPeriodo";
            this.textPeriodo.Size = new System.Drawing.Size(113, 27);
            this.textPeriodo.TabIndex = 3;
            this.textPeriodo.Text = "0";
            this.textPeriodo.TextChanged += new System.EventHandler(this.textPeriodo_TextChanged);
            // 
            // SelectPeriodo
            // 
            this.SelectPeriodo.BackColor = System.Drawing.Color.Lavender;
            this.SelectPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectPeriodo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectPeriodo.FormattingEnabled = true;
            this.SelectPeriodo.Items.AddRange(new object[] {
            "Semanal",
            "Quincenal",
            "Mensual",
            "Anual"});
            this.SelectPeriodo.Location = new System.Drawing.Point(86, 134);
            this.SelectPeriodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectPeriodo.Name = "SelectPeriodo";
            this.SelectPeriodo.Size = new System.Drawing.Size(118, 28);
            this.SelectPeriodo.TabIndex = 5;
            this.SelectPeriodo.SelectedIndexChanged += new System.EventHandler(this.SelectPeriodo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.PeachPuff;
            this.label5.Location = new System.Drawing.Point(11, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Periodo:";
            // 
            // SelectPago
            // 
            this.SelectPago.BackColor = System.Drawing.Color.Lavender;
            this.SelectPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectPago.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectPago.FormattingEnabled = true;
            this.SelectPago.Items.AddRange(new object[] {
            "Diario",
            "Interdiario",
            "Semanal",
            "Quincenal",
            "Mensual",
            "Anual"});
            this.SelectPago.Location = new System.Drawing.Point(86, 194);
            this.SelectPago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectPago.Name = "SelectPago";
            this.SelectPago.Size = new System.Drawing.Size(118, 28);
            this.SelectPago.TabIndex = 6;
            this.SelectPago.SelectedIndexChanged += new System.EventHandler(this.SelectPago_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.PeachPuff;
            this.label4.Location = new System.Drawing.Point(11, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pago:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(14, 249);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(375, 241);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(290, 249);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 53);
            this.button2.TabIndex = 8;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Deuda
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(398, 501);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SelectPago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPeriodo);
            this.Controls.Add(this.SelectPeriodo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textInteres);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SelectInteres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCapital);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Deuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalcPrestamo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Deuda_FormClosed);
            this.Load += new System.EventHandler(this.Deuda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCapital;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectInteres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textInteres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPeriodo;
        private System.Windows.Forms.ComboBox SelectPeriodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SelectPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
    }
}