
namespace Calculadoras
{
    partial class Tabla_CalcPres
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DatosTabla = new System.Windows.Forms.DataGridView();
            this.ColumnPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tmontofinal = new System.Windows.Forms.Label();
            this.tint = new System.Windows.Forms.Label();
            this.tmonto = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DatosTabla)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(681, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resultados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(222, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cuota";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(310, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amortización";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(430, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Interés";
            // 
            // DatosTabla
            // 
            this.DatosTabla.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.DatosTabla.AllowUserToDeleteRows = false;
            this.DatosTabla.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.DatosTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatosTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPay,
            this.ColumnCuota,
            this.ColumnInteres,
            this.ColumnSaldo});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatosTabla.DefaultCellStyle = dataGridViewCellStyle1;
            this.DatosTabla.GridColor = System.Drawing.SystemColors.Desktop;
            this.DatosTabla.Location = new System.Drawing.Point(12, 74);
            this.DatosTabla.MultiSelect = false;
            this.DatosTabla.Name = "DatosTabla";
            this.DatosTabla.ReadOnly = true;
            this.DatosTabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DatosTabla.RowTemplate.Height = 25;
            this.DatosTabla.RowTemplate.ReadOnly = true;
            this.DatosTabla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DatosTabla.Size = new System.Drawing.Size(522, 362);
            this.DatosTabla.TabIndex = 7;
            this.DatosTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnPay
            // 
            this.ColumnPay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnPay.FillWeight = 140F;
            this.ColumnPay.HeaderText = "Pago(s)";
            this.ColumnPay.MaxInputLength = 20;
            this.ColumnPay.Name = "ColumnPay";
            this.ColumnPay.ReadOnly = true;
            this.ColumnPay.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnPay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnPay.Width = 120;
            // 
            // ColumnCuota
            // 
            this.ColumnCuota.HeaderText = "Cuota";
            this.ColumnCuota.MaxInputLength = 20;
            this.ColumnCuota.Name = "ColumnCuota";
            this.ColumnCuota.ReadOnly = true;
            this.ColumnCuota.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnCuota.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnCuota.Width = 120;
            // 
            // ColumnInteres
            // 
            this.ColumnInteres.HeaderText = "Interés";
            this.ColumnInteres.MaxInputLength = 20;
            this.ColumnInteres.Name = "ColumnInteres";
            this.ColumnInteres.ReadOnly = true;
            this.ColumnInteres.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnInteres.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnInteres.Width = 120;
            // 
            // ColumnSaldo
            // 
            this.ColumnSaldo.HeaderText = "Saldo";
            this.ColumnSaldo.MaxInputLength = 20;
            this.ColumnSaldo.Name = "ColumnSaldo";
            this.ColumnSaldo.ReadOnly = true;
            this.ColumnSaldo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnSaldo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnSaldo.Width = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(197, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Plan de Amortización";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tmontofinal);
            this.panel1.Controls.Add(this.tint);
            this.panel1.Controls.Add(this.tmonto);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(608, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 273);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // tmontofinal
            // 
            this.tmontofinal.AutoSize = true;
            this.tmontofinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tmontofinal.ForeColor = System.Drawing.Color.Chocolate;
            this.tmontofinal.Location = new System.Drawing.Point(48, 239);
            this.tmontofinal.Name = "tmontofinal";
            this.tmontofinal.Size = new System.Drawing.Size(19, 21);
            this.tmontofinal.TabIndex = 5;
            this.tmontofinal.Text = "0";
            // 
            // tint
            // 
            this.tint.AutoSize = true;
            this.tint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tint.ForeColor = System.Drawing.Color.Chocolate;
            this.tint.Location = new System.Drawing.Point(48, 154);
            this.tint.Name = "tint";
            this.tint.Size = new System.Drawing.Size(19, 21);
            this.tint.TabIndex = 4;
            this.tint.Text = "0";
            // 
            // tmonto
            // 
            this.tmonto.AutoSize = true;
            this.tmonto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tmonto.ForeColor = System.Drawing.Color.Chocolate;
            this.tmonto.Location = new System.Drawing.Point(48, 59);
            this.tmonto.Name = "tmonto";
            this.tmonto.Size = new System.Drawing.Size(19, 21);
            this.tmonto.TabIndex = 3;
            this.tmonto.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(48, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Monto Total Pagado: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(48, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total en Intereses: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(48, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Monto Principal: ";
            // 
            // Tabla_CalcPres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(875, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DatosTabla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Tabla_CalcPres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla_CalcPres";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Tabla_CalcPres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosTabla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView DatosTabla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tmontofinal;
        private System.Windows.Forms.Label tint;
        private System.Windows.Forms.Label tmonto;
    }
}