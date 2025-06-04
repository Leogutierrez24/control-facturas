namespace UI
{
    partial class frmHome
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Prestadores_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CargarFactura_btn = new System.Windows.Forms.Button();
            this.BuscarFactura_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.Filt_btn = new System.Windows.Forms.Button();
            this.Filter_lbl = new System.Windows.Forms.Label();
            this.Filter_textBox = new System.Windows.Forms.TextBox();
            this.Option03_radioButton = new System.Windows.Forms.RadioButton();
            this.Option02_radioButton = new System.Windows.Forms.RadioButton();
            this.Option01_radioButton = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CargarPago_btn = new System.Windows.Forms.Button();
            this.BuscarPago_btn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CargarDebito_btn = new System.Windows.Forms.Button();
            this.BuscarDebito_btn = new System.Windows.Forms.Button();
            this.NuevoPrestador_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Prestadores_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Prestadores_dataGridView
            // 
            this.Prestadores_dataGridView.AllowUserToResizeColumns = false;
            this.Prestadores_dataGridView.AllowUserToResizeRows = false;
            this.Prestadores_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prestadores_dataGridView.Location = new System.Drawing.Point(12, 25);
            this.Prestadores_dataGridView.MultiSelect = false;
            this.Prestadores_dataGridView.Name = "Prestadores_dataGridView";
            this.Prestadores_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Prestadores_dataGridView.Size = new System.Drawing.Size(667, 627);
            this.Prestadores_dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Prestadores";
            // 
            // CargarFactura_btn
            // 
            this.CargarFactura_btn.Location = new System.Drawing.Point(26, 19);
            this.CargarFactura_btn.Name = "CargarFactura_btn";
            this.CargarFactura_btn.Size = new System.Drawing.Size(92, 36);
            this.CargarFactura_btn.TabIndex = 2;
            this.CargarFactura_btn.Text = "Cargar Factura";
            this.CargarFactura_btn.UseVisualStyleBackColor = true;
            this.CargarFactura_btn.Click += new System.EventHandler(this.CargarFactura_btn_Click);
            // 
            // BuscarFactura_btn
            // 
            this.BuscarFactura_btn.Location = new System.Drawing.Point(26, 72);
            this.BuscarFactura_btn.Name = "BuscarFactura_btn";
            this.BuscarFactura_btn.Size = new System.Drawing.Size(92, 36);
            this.BuscarFactura_btn.TabIndex = 3;
            this.BuscarFactura_btn.Text = "Buscar Factura";
            this.BuscarFactura_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.Filt_btn);
            this.groupBox1.Controls.Add(this.Filter_lbl);
            this.groupBox1.Controls.Add(this.Filter_textBox);
            this.groupBox1.Controls.Add(this.Option03_radioButton);
            this.groupBox1.Controls.Add(this.Option02_radioButton);
            this.groupBox1.Controls.Add(this.Option01_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(685, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 87);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar Prestadores";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(262, 26);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 22);
            this.button9.TabIndex = 8;
            this.button9.Text = "Revertir";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Rollback_btn_Click);
            // 
            // Filt_btn
            // 
            this.Filt_btn.Location = new System.Drawing.Point(182, 26);
            this.Filt_btn.Name = "Filt_btn";
            this.Filt_btn.Size = new System.Drawing.Size(74, 23);
            this.Filt_btn.TabIndex = 7;
            this.Filt_btn.Text = "Filtrar";
            this.Filt_btn.UseVisualStyleBackColor = true;
            this.Filt_btn.Click += new System.EventHandler(this.Filt_btn_Click);
            // 
            // Filter_lbl
            // 
            this.Filter_lbl.AutoSize = true;
            this.Filter_lbl.Location = new System.Drawing.Point(6, 59);
            this.Filter_lbl.Name = "Filter_lbl";
            this.Filter_lbl.Size = new System.Drawing.Size(80, 13);
            this.Filter_lbl.TabIndex = 6;
            this.Filter_lbl.Text = "Punto de venta";
            // 
            // Filter_textBox
            // 
            this.Filter_textBox.Location = new System.Drawing.Point(92, 56);
            this.Filter_textBox.Name = "Filter_textBox";
            this.Filter_textBox.Size = new System.Drawing.Size(195, 20);
            this.Filter_textBox.TabIndex = 5;
            // 
            // Option03_radioButton
            // 
            this.Option03_radioButton.AutoSize = true;
            this.Option03_radioButton.Location = new System.Drawing.Point(114, 29);
            this.Option03_radioButton.Name = "Option03_radioButton";
            this.Option03_radioButton.Size = new System.Drawing.Size(62, 17);
            this.Option03_radioButton.TabIndex = 3;
            this.Option03_radioButton.Text = "Nombre";
            this.Option03_radioButton.UseVisualStyleBackColor = true;
            this.Option03_radioButton.CheckedChanged += new System.EventHandler(this.Option03_radioButton_CheckedChanged);
            // 
            // Option02_radioButton
            // 
            this.Option02_radioButton.AutoSize = true;
            this.Option02_radioButton.Location = new System.Drawing.Point(60, 29);
            this.Option02_radioButton.Name = "Option02_radioButton";
            this.Option02_radioButton.Size = new System.Drawing.Size(48, 17);
            this.Option02_radioButton.TabIndex = 1;
            this.Option02_radioButton.Text = "Z - A";
            this.Option02_radioButton.UseVisualStyleBackColor = true;
            this.Option02_radioButton.CheckedChanged += new System.EventHandler(this.Option02_radioButton_CheckedChanged);
            // 
            // Option01_radioButton
            // 
            this.Option01_radioButton.AutoSize = true;
            this.Option01_radioButton.Checked = true;
            this.Option01_radioButton.Location = new System.Drawing.Point(6, 29);
            this.Option01_radioButton.Name = "Option01_radioButton";
            this.Option01_radioButton.Size = new System.Drawing.Size(48, 17);
            this.Option01_radioButton.TabIndex = 0;
            this.Option01_radioButton.TabStop = true;
            this.Option01_radioButton.Text = "A - Z";
            this.Option01_radioButton.UseVisualStyleBackColor = true;
            this.Option01_radioButton.CheckedChanged += new System.EventHandler(this.Option01_radioButton_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(786, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "Ver Prestador";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CargarFactura_btn);
            this.groupBox2.Controls.Add(this.BuscarFactura_btn);
            this.groupBox2.Location = new System.Drawing.Point(685, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 125);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Facturacion";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CargarPago_btn);
            this.groupBox3.Controls.Add(this.BuscarPago_btn);
            this.groupBox3.Location = new System.Drawing.Point(838, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 125);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pagos";
            // 
            // CargarPago_btn
            // 
            this.CargarPago_btn.Location = new System.Drawing.Point(26, 19);
            this.CargarPago_btn.Name = "CargarPago_btn";
            this.CargarPago_btn.Size = new System.Drawing.Size(92, 36);
            this.CargarPago_btn.TabIndex = 2;
            this.CargarPago_btn.Text = "Cargar Pago";
            this.CargarPago_btn.UseVisualStyleBackColor = true;
            // 
            // BuscarPago_btn
            // 
            this.BuscarPago_btn.Location = new System.Drawing.Point(26, 72);
            this.BuscarPago_btn.Name = "BuscarPago_btn";
            this.BuscarPago_btn.Size = new System.Drawing.Size(92, 36);
            this.BuscarPago_btn.TabIndex = 3;
            this.BuscarPago_btn.Text = "Buscar Pago";
            this.BuscarPago_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CargarDebito_btn);
            this.groupBox4.Controls.Add(this.BuscarDebito_btn);
            this.groupBox4.Location = new System.Drawing.Point(991, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(147, 125);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Debitos";
            // 
            // CargarDebito_btn
            // 
            this.CargarDebito_btn.Location = new System.Drawing.Point(26, 19);
            this.CargarDebito_btn.Name = "CargarDebito_btn";
            this.CargarDebito_btn.Size = new System.Drawing.Size(92, 36);
            this.CargarDebito_btn.TabIndex = 2;
            this.CargarDebito_btn.Text = "Cargar Debito";
            this.CargarDebito_btn.UseVisualStyleBackColor = true;
            // 
            // BuscarDebito_btn
            // 
            this.BuscarDebito_btn.Location = new System.Drawing.Point(26, 72);
            this.BuscarDebito_btn.Name = "BuscarDebito_btn";
            this.BuscarDebito_btn.Size = new System.Drawing.Size(92, 36);
            this.BuscarDebito_btn.TabIndex = 3;
            this.BuscarDebito_btn.Text = "Buscar Debito";
            this.BuscarDebito_btn.UseVisualStyleBackColor = true;
            // 
            // NuevoPrestador_btn
            // 
            this.NuevoPrestador_btn.Location = new System.Drawing.Point(685, 118);
            this.NuevoPrestador_btn.Name = "NuevoPrestador_btn";
            this.NuevoPrestador_btn.Size = new System.Drawing.Size(95, 40);
            this.NuevoPrestador_btn.TabIndex = 10;
            this.NuevoPrestador_btn.Text = "Cargar Nuevo Prestador";
            this.NuevoPrestador_btn.UseVisualStyleBackColor = true;
            this.NuevoPrestador_btn.Click += new System.EventHandler(this.NuevoPrestador_btn_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 675);
            this.Controls.Add(this.NuevoPrestador_btn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prestadores_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Facturación OSDEL";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Prestadores_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Prestadores_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CargarFactura_btn;
        private System.Windows.Forms.Button BuscarFactura_btn;
        private System.Windows.Forms.Button CargarPrestador_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Filter_textBox;
        private System.Windows.Forms.RadioButton Option03_radioButton;
        private System.Windows.Forms.RadioButton Option02_radioButton;
        private System.Windows.Forms.RadioButton Option01_radioButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Filter_lbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CargarPago_btn;
        private System.Windows.Forms.Button BuscarPago_btn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button CargarDebito_btn;
        private System.Windows.Forms.Button BuscarDebito_btn;
        private System.Windows.Forms.Button Filt_btn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button NuevoPrestador_btn;
    }
}

