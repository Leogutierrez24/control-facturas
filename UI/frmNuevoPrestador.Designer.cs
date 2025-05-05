namespace UI
{
    partial class frmNuevoPrestador
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
            this.prestadorNombre_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Registrar_btn = new System.Windows.Forms.Button();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.ErrorMessage_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.puntoVenta_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.puntoVenta_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // prestadorNombre_textBox
            // 
            this.prestadorNombre_textBox.Location = new System.Drawing.Point(15, 49);
            this.prestadorNombre_textBox.Name = "prestadorNombre_textBox";
            this.prestadorNombre_textBox.Size = new System.Drawing.Size(254, 20);
            this.prestadorNombre_textBox.TabIndex = 0;
            this.prestadorNombre_textBox.TextChanged += new System.EventHandler(this.prestadorNombre_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar Nuevo Prestador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "* Es necesario que el nombre tenga un mínimo de 5 caracteres.";
            // 
            // Registrar_btn
            // 
            this.Registrar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registrar_btn.Location = new System.Drawing.Point(287, 49);
            this.Registrar_btn.Name = "Registrar_btn";
            this.Registrar_btn.Size = new System.Drawing.Size(74, 36);
            this.Registrar_btn.TabIndex = 4;
            this.Registrar_btn.Text = "Registrar";
            this.Registrar_btn.UseVisualStyleBackColor = true;
            this.Registrar_btn.Click += new System.EventHandler(this.Registrar_btn_Click);
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancelar_btn.Location = new System.Drawing.Point(287, 89);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancelar_btn.TabIndex = 5;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.UseVisualStyleBackColor = true;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // ErrorMessage_lbl
            // 
            this.ErrorMessage_lbl.AutoSize = true;
            this.ErrorMessage_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessage_lbl.ForeColor = System.Drawing.Color.IndianRed;
            this.ErrorMessage_lbl.Location = new System.Drawing.Point(12, 132);
            this.ErrorMessage_lbl.Name = "ErrorMessage_lbl";
            this.ErrorMessage_lbl.Size = new System.Drawing.Size(97, 13);
            this.ErrorMessage_lbl.TabIndex = 6;
            this.ErrorMessage_lbl.Text = "* Error Message";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Punto de venta";
            // 
            // puntoVenta_numericUpDown
            // 
            this.puntoVenta_numericUpDown.Location = new System.Drawing.Point(15, 97);
            this.puntoVenta_numericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.puntoVenta_numericUpDown.Name = "puntoVenta_numericUpDown";
            this.puntoVenta_numericUpDown.Size = new System.Drawing.Size(95, 20);
            this.puntoVenta_numericUpDown.TabIndex = 9;
            this.puntoVenta_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.puntoVenta_numericUpDown.ValueChanged += new System.EventHandler(this.puntoVenta_numericUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "(Para no indicar, dejar en 0)";
            // 
            // frmNuevoPrestador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 205);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.puntoVenta_numericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ErrorMessage_lbl);
            this.Controls.Add(this.Cancelar_btn);
            this.Controls.Add(this.Registrar_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prestadorNombre_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmNuevoPrestador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cargar Prestador";
            this.Load += new System.EventHandler(this.frmNuevoPrestador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.puntoVenta_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prestadorNombre_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Registrar_btn;
        private System.Windows.Forms.Button Cancelar_btn;
        private System.Windows.Forms.Label ErrorMessage_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown puntoVenta_numericUpDown;
        private System.Windows.Forms.Label label6;
    }
}