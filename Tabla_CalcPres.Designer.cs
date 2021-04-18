
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
            this.ColumnAmorti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DatosTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(726, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 30);
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
            this.ColumnAmorti,
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
            this.DatosTabla.Location = new System.Drawing.Point(2, 12);
            this.DatosTabla.MultiSelect = false;
            this.DatosTabla.Name = "DatosTabla";
            this.DatosTabla.ReadOnly = true;
            this.DatosTabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DatosTabla.RowTemplate.Height = 25;
            this.DatosTabla.RowTemplate.ReadOnly = true;
            this.DatosTabla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DatosTabla.Size = new System.Drawing.Size(649, 424);
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
            // ColumnAmorti
            // 
            this.ColumnAmorti.HeaderText = "Amortización";
            this.ColumnAmorti.MaxInputLength = 20;
            this.ColumnAmorti.Name = "ColumnAmorti";
            this.ColumnAmorti.ReadOnly = true;
            this.ColumnAmorti.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnAmorti.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnAmorti.Width = 120;
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
            // Tabla_CalcPres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(928, 448);
            this.Controls.Add(this.DatosTabla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Tabla_CalcPres";
            this.Text = "Tabla_CalcPres";
            this.Load += new System.EventHandler(this.Tabla_CalcPres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView DatosTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmorti;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSaldo;
        private System.Windows.Forms.Timer timer1;
    }
}