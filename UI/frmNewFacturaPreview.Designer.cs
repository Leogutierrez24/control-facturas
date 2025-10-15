namespace UI
{
    partial class frmNewFacturaPreview
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
            this.Prestador_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Numero_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PuntoVenta_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Total_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FechaRecepcion_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FechaEmision_textBox = new System.Windows.Forms.TextBox();
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar la siguiente factura al prestador:";
            // 
            // Prestador_lbl
            // 
            this.Prestador_lbl.AutoSize = true;
            this.Prestador_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prestador_lbl.Location = new System.Drawing.Point(19, 33);
            this.Prestador_lbl.Name = "Prestador_lbl";
            this.Prestador_lbl.Size = new System.Drawing.Size(129, 13);
            this.Prestador_lbl.TabIndex = 1;
            this.Prestador_lbl.Text = "Nombre del Prestador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Numero:";
            // 
            // Numero_textBox
            // 
            this.Numero_textBox.Location = new System.Drawing.Point(31, 91);
            this.Numero_textBox.MaxLength = 10;
            this.Numero_textBox.Name = "Numero_textBox";
            this.Numero_textBox.ReadOnly = true;
            this.Numero_textBox.Size = new System.Drawing.Size(256, 20);
            this.Numero_textBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Punto de venta:";
            // 
            // PuntoVenta_textBox
            // 
            this.PuntoVenta_textBox.Location = new System.Drawing.Point(31, 42);
            this.PuntoVenta_textBox.MaxLength = 6;
            this.PuntoVenta_textBox.Name = "PuntoVenta_textBox";
            this.PuntoVenta_textBox.ReadOnly = true;
            this.PuntoVenta_textBox.Size = new System.Drawing.Size(256, 20);
            this.PuntoVenta_textBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Total_textBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.FechaRecepcion_textBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.FechaEmision_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PuntoVenta_textBox);
            this.groupBox1.Controls.Add(this.Numero_textBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 299);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Factura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Total:";
            // 
            // Total_textBox
            // 
            this.Total_textBox.Location = new System.Drawing.Point(31, 245);
            this.Total_textBox.MaxLength = 10;
            this.Total_textBox.Name = "Total_textBox";
            this.Total_textBox.ReadOnly = true;
            this.Total_textBox.Size = new System.Drawing.Size(256, 20);
            this.Total_textBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fecha de recepcion:";
            // 
            // FechaRecepcion_textBox
            // 
            this.FechaRecepcion_textBox.Location = new System.Drawing.Point(31, 193);
            this.FechaRecepcion_textBox.MaxLength = 10;
            this.FechaRecepcion_textBox.Name = "FechaRecepcion_textBox";
            this.FechaRecepcion_textBox.ReadOnly = true;
            this.FechaRecepcion_textBox.Size = new System.Drawing.Size(256, 20);
            this.FechaRecepcion_textBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha de emision:";
            // 
            // FechaEmision_textBox
            // 
            this.FechaEmision_textBox.Location = new System.Drawing.Point(31, 143);
            this.FechaEmision_textBox.MaxLength = 10;
            this.FechaEmision_textBox.Name = "FechaEmision_textBox";
            this.FechaEmision_textBox.ReadOnly = true;
            this.FechaEmision_textBox.Size = new System.Drawing.Size(256, 20);
            this.FechaEmision_textBox.TabIndex = 14;
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.Location = new System.Drawing.Point(15, 363);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(92, 37);
            this.Confirm_btn.TabIndex = 15;
            this.Confirm_btn.Text = "Aceptar";
            this.Confirm_btn.UseVisualStyleBackColor = true;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(252, 363);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(92, 37);
            this.Cancel_btn.TabIndex = 16;
            this.Cancel_btn.Text = "Volver";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // frmNewFacturaPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 411);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Prestador_lbl);
            this.Controls.Add(this.label1);
            this.Name = "frmNewFacturaPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva Factura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Prestador_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Numero_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PuntoVenta_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FechaRecepcion_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FechaEmision_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Total_textBox;
        private System.Windows.Forms.Button Confirm_btn;
        private System.Windows.Forms.Button Cancel_btn;
    }
}