namespace UI
{
    partial class frmCargarFactura
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
            this.Prestadores_dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.PrestadorName_textBox = new System.Windows.Forms.TextBox();
            this.FiltPrestadores_button = new System.Windows.Forms.Button();
            this.PuntoVenta_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Reset_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Numero_textBox = new System.Windows.Forms.TextBox();
            this.PuntoVenta_checkBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FechaRecepcion_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaFactura_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Monto_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Observaciones_textBox = new System.Windows.Forms.TextBox();
            this.LoadFactura_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.ResetInputs_button = new System.Windows.Forms.Button();
            this.ErrorMessage_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Prestadores_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Monto_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Prestadores_dataGridView
            // 
            this.Prestadores_dataGridView.AllowUserToResizeColumns = false;
            this.Prestadores_dataGridView.AllowUserToResizeRows = false;
            this.Prestadores_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prestadores_dataGridView.Location = new System.Drawing.Point(15, 19);
            this.Prestadores_dataGridView.MultiSelect = false;
            this.Prestadores_dataGridView.Name = "Prestadores_dataGridView";
            this.Prestadores_dataGridView.ReadOnly = true;
            this.Prestadores_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Prestadores_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Prestadores_dataGridView.Size = new System.Drawing.Size(452, 150);
            this.Prestadores_dataGridView.TabIndex = 0;
            this.Prestadores_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Prestadores_dataGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filtrar por nombre";
            // 
            // PrestadorName_textBox
            // 
            this.PrestadorName_textBox.Location = new System.Drawing.Point(18, 188);
            this.PrestadorName_textBox.Name = "PrestadorName_textBox";
            this.PrestadorName_textBox.Size = new System.Drawing.Size(353, 20);
            this.PrestadorName_textBox.TabIndex = 3;
            // 
            // FiltPrestadores_button
            // 
            this.FiltPrestadores_button.Location = new System.Drawing.Point(392, 178);
            this.FiltPrestadores_button.Name = "FiltPrestadores_button";
            this.FiltPrestadores_button.Size = new System.Drawing.Size(75, 38);
            this.FiltPrestadores_button.TabIndex = 4;
            this.FiltPrestadores_button.Text = "Filtrar prestadores";
            this.FiltPrestadores_button.UseVisualStyleBackColor = true;
            this.FiltPrestadores_button.Click += new System.EventHandler(this.FiltPrestadores_button_Click);
            // 
            // PuntoVenta_textBox
            // 
            this.PuntoVenta_textBox.Location = new System.Drawing.Point(510, 28);
            this.PuntoVenta_textBox.MaxLength = 6;
            this.PuntoVenta_textBox.Name = "PuntoVenta_textBox";
            this.PuntoVenta_textBox.Size = new System.Drawing.Size(157, 20);
            this.PuntoVenta_textBox.TabIndex = 5;
            this.PuntoVenta_textBox.TextChanged += new System.EventHandler(this.PuntoVenta_textBox_TextChanged);
            this.PuntoVenta_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PuntoVenta_textBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Reset_button);
            this.groupBox1.Controls.Add(this.Prestadores_dataGridView);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FiltPrestadores_button);
            this.groupBox1.Controls.Add(this.PrestadorName_textBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 268);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciona un Prestador";
            // 
            // Reset_button
            // 
            this.Reset_button.Location = new System.Drawing.Point(18, 219);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(75, 33);
            this.Reset_button.TabIndex = 5;
            this.Reset_button.Text = "Revertir";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Punto de venta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numero:";
            // 
            // Numero_textBox
            // 
            this.Numero_textBox.Location = new System.Drawing.Point(510, 77);
            this.Numero_textBox.MaxLength = 10;
            this.Numero_textBox.Name = "Numero_textBox";
            this.Numero_textBox.Size = new System.Drawing.Size(157, 20);
            this.Numero_textBox.TabIndex = 8;
            this.Numero_textBox.TextChanged += new System.EventHandler(this.Numero_textBox_TextChanged);
            this.Numero_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_textBox_KeyPress);
            // 
            // PuntoVenta_checkBox
            // 
            this.PuntoVenta_checkBox.AutoSize = true;
            this.PuntoVenta_checkBox.Location = new System.Drawing.Point(673, 30);
            this.PuntoVenta_checkBox.Name = "PuntoVenta_checkBox";
            this.PuntoVenta_checkBox.Size = new System.Drawing.Size(108, 17);
            this.PuntoVenta_checkBox.TabIndex = 10;
            this.PuntoVenta_checkBox.Text = "s/punto de venta";
            this.PuntoVenta_checkBox.UseVisualStyleBackColor = true;
            this.PuntoVenta_checkBox.CheckedChanged += new System.EventHandler(this.PuntoVenta_checkBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha de recepcion:";
            // 
            // FechaRecepcion_dateTimePicker
            // 
            this.FechaRecepcion_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaRecepcion_dateTimePicker.Location = new System.Drawing.Point(510, 184);
            this.FechaRecepcion_dateTimePicker.Name = "FechaRecepcion_dateTimePicker";
            this.FechaRecepcion_dateTimePicker.Size = new System.Drawing.Size(157, 20);
            this.FechaRecepcion_dateTimePicker.TabIndex = 12;
            this.FechaRecepcion_dateTimePicker.ValueChanged += new System.EventHandler(this.FechaRecepcion_dateTimePicker_ValueChanged);
            // 
            // FechaFactura_dateTimePicker
            // 
            this.FechaFactura_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaFactura_dateTimePicker.Location = new System.Drawing.Point(510, 131);
            this.FechaFactura_dateTimePicker.Name = "FechaFactura_dateTimePicker";
            this.FechaFactura_dateTimePicker.Size = new System.Drawing.Size(157, 20);
            this.FechaFactura_dateTimePicker.TabIndex = 14;
            this.FechaFactura_dateTimePicker.ValueChanged += new System.EventHandler(this.FechaFactura_dateTimePicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha de la factura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total:";
            // 
            // Monto_numericUpDown
            // 
            this.Monto_numericUpDown.DecimalPlaces = 2;
            this.Monto_numericUpDown.Location = new System.Drawing.Point(510, 239);
            this.Monto_numericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Monto_numericUpDown.Name = "Monto_numericUpDown";
            this.Monto_numericUpDown.Size = new System.Drawing.Size(157, 20);
            this.Monto_numericUpDown.TabIndex = 16;
            this.Monto_numericUpDown.ValueChanged += new System.EventHandler(this.Monto_numericUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Observaciones:";
            // 
            // Observaciones_textBox
            // 
            this.Observaciones_textBox.Location = new System.Drawing.Point(15, 301);
            this.Observaciones_textBox.Multiline = true;
            this.Observaciones_textBox.Name = "Observaciones_textBox";
            this.Observaciones_textBox.Size = new System.Drawing.Size(464, 169);
            this.Observaciones_textBox.TabIndex = 5;
            // 
            // LoadFactura_button
            // 
            this.LoadFactura_button.Location = new System.Drawing.Point(15, 476);
            this.LoadFactura_button.Name = "LoadFactura_button";
            this.LoadFactura_button.Size = new System.Drawing.Size(109, 43);
            this.LoadFactura_button.TabIndex = 18;
            this.LoadFactura_button.Text = "Cargar Nueva Factura";
            this.LoadFactura_button.UseVisualStyleBackColor = true;
            this.LoadFactura_button.Click += new System.EventHandler(this.LoadFactura_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(660, 476);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(109, 43);
            this.Cancel_button.TabIndex = 19;
            this.Cancel_button.Text = "Cancelar";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // ResetInputs_button
            // 
            this.ResetInputs_button.Location = new System.Drawing.Point(130, 476);
            this.ResetInputs_button.Name = "ResetInputs_button";
            this.ResetInputs_button.Size = new System.Drawing.Size(109, 43);
            this.ResetInputs_button.TabIndex = 20;
            this.ResetInputs_button.Text = "Restablecer campos";
            this.ResetInputs_button.UseVisualStyleBackColor = true;
            this.ResetInputs_button.Click += new System.EventHandler(this.ResetInputs_button_Click);
            // 
            // ErrorMessage_label
            // 
            this.ErrorMessage_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessage_label.ForeColor = System.Drawing.Color.IndianRed;
            this.ErrorMessage_label.Location = new System.Drawing.Point(507, 304);
            this.ErrorMessage_label.Name = "ErrorMessage_label";
            this.ErrorMessage_label.Size = new System.Drawing.Size(262, 166);
            this.ErrorMessage_label.TabIndex = 21;
            this.ErrorMessage_label.Text = "Mensaje de error";
            // 
            // frmCargarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 531);
            this.Controls.Add(this.ErrorMessage_label);
            this.Controls.Add(this.ResetInputs_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.LoadFactura_button);
            this.Controls.Add(this.Observaciones_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Monto_numericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FechaFactura_dateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FechaRecepcion_dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PuntoVenta_checkBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Numero_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PuntoVenta_textBox);
            this.Name = "frmCargarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva Factura";
            ((System.ComponentModel.ISupportInitialize)(this.Prestadores_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Monto_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Prestadores_dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrestadorName_textBox;
        private System.Windows.Forms.Button FiltPrestadores_button;
        private System.Windows.Forms.TextBox PuntoVenta_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Numero_textBox;
        private System.Windows.Forms.CheckBox PuntoVenta_checkBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker FechaRecepcion_dateTimePicker;
        private System.Windows.Forms.DateTimePicker FechaFactura_dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Monto_numericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Observaciones_textBox;
        private System.Windows.Forms.Button LoadFactura_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button ResetInputs_button;
        private System.Windows.Forms.Label ErrorMessage_label;
        private System.Windows.Forms.Button Reset_button;
    }
}