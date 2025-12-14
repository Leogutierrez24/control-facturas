namespace UI
{
    partial class frmSearchFactura
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FilterOptions_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Facturas_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Facturas_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar facturas por:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 20);
            this.textBox1.TabIndex = 1;
            // 
            // FilterOptions_comboBox
            // 
            this.FilterOptions_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterOptions_comboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FilterOptions_comboBox.FormattingEnabled = true;
            this.FilterOptions_comboBox.Items.AddRange(new object[] {
            "PUNTO DE VENTA",
            "NUMERO",
            "MONTO",
            "PRESTADOR",
            "PAGAS",
            "PENDIENTE",
            "RECHAZADAS",
            "DEBITADAS",
            "VENCIDAS"});
            this.FilterOptions_comboBox.Location = new System.Drawing.Point(112, 68);
            this.FilterOptions_comboBox.Name = "FilterOptions_comboBox";
            this.FilterOptions_comboBox.Size = new System.Drawing.Size(253, 21);
            this.FilterOptions_comboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filtro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Facturas_dataGridView
            // 
            this.Facturas_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Facturas_dataGridView.Location = new System.Drawing.Point(15, 134);
            this.Facturas_dataGridView.Name = "Facturas_dataGridView";
            this.Facturas_dataGridView.Size = new System.Drawing.Size(524, 150);
            this.Facturas_dataGridView.TabIndex = 5;
            // 
            // frmSearchFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Facturas_dataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FilterOptions_comboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmSearchFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Factura";
            ((System.ComponentModel.ISupportInitialize)(this.Facturas_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox FilterOptions_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Facturas_dataGridView;
    }
}