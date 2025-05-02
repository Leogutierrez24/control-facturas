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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Prestadores_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Prestadores_dataGridView
            // 
            this.Prestadores_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prestadores_dataGridView.Location = new System.Drawing.Point(12, 25);
            this.Prestadores_dataGridView.Name = "Prestadores_dataGridView";
            this.Prestadores_dataGridView.Size = new System.Drawing.Size(424, 627);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cargar Factura";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Buscar Factura";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(442, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cargar Nuevo Prestador";
            this.button3.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(442, 25);
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
            this.button4.Location = new System.Drawing.Point(543, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "Ver Prestador";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(442, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 125);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Facturacion";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Location = new System.Drawing.Point(595, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 125);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pagos";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(26, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 36);
            this.button5.TabIndex = 2;
            this.button5.Text = "Cargar Pago";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(26, 72);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 36);
            this.button6.TabIndex = 3;
            this.button6.Text = "Buscar Pago";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Location = new System.Drawing.Point(748, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(147, 125);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Debitos";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(26, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 36);
            this.button7.TabIndex = 2;
            this.button7.Text = "Cargar Debito";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(26, 72);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 36);
            this.button8.TabIndex = 3;
            this.button8.Text = "Buscar Debito";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 677);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prestadores_dataGridView);
            this.Name = "frmHome";
            this.Text = "Control de Facturación OSDEL";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Filter_textBox;
        private System.Windows.Forms.RadioButton Option03_radioButton;
        private System.Windows.Forms.RadioButton Option02_radioButton;
        private System.Windows.Forms.RadioButton Option01_radioButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Filter_lbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Filt_btn;
        private System.Windows.Forms.Button button9;
    }
}

