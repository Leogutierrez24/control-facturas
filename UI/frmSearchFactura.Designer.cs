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
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.FilterOptions_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Facturas_dataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.ShowFactura_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Facturas_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar facturas por:";
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(15, 25);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(379, 20);
            this.Search_textBox.TabIndex = 1;
            // 
            // FilterOptions_comboBox
            // 
            this.FilterOptions_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterOptions_comboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FilterOptions_comboBox.FormattingEnabled = true;
            this.FilterOptions_comboBox.Location = new System.Drawing.Point(112, 78);
            this.FilterOptions_comboBox.Name = "FilterOptions_comboBox";
            this.FilterOptions_comboBox.Size = new System.Drawing.Size(282, 21);
            this.FilterOptions_comboBox.TabIndex = 2;
            this.FilterOptions_comboBox.SelectedIndexChanged += new System.EventHandler(this.FilterOptions_comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscador";
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(400, 25);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(79, 32);
            this.Search_btn.TabIndex = 4;
            this.Search_btn.Text = "Buscar";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Facturas_dataGridView
            // 
            this.Facturas_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Facturas_dataGridView.Location = new System.Drawing.Point(15, 143);
            this.Facturas_dataGridView.MultiSelect = false;
            this.Facturas_dataGridView.Name = "Facturas_dataGridView";
            this.Facturas_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Facturas_dataGridView.Size = new System.Drawing.Size(524, 273);
            this.Facturas_dataGridView.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Listado de facturas";
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(460, 422);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(79, 35);
            this.Cancel_btn.TabIndex = 7;
            this.Cancel_btn.Text = "Cerrar";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // ShowFactura_btn
            // 
            this.ShowFactura_btn.Location = new System.Drawing.Point(15, 422);
            this.ShowFactura_btn.Name = "ShowFactura_btn";
            this.ShowFactura_btn.Size = new System.Drawing.Size(79, 36);
            this.ShowFactura_btn.TabIndex = 8;
            this.ShowFactura_btn.Text = "Ver Factura";
            this.ShowFactura_btn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(371, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "* En caso de buscar por montos, separar los valores decimales con punto ( . )";
            // 
            // frmSearchFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 469);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShowFactura_btn);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Facturas_dataGridView);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FilterOptions_comboBox);
            this.Controls.Add(this.Search_textBox);
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
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.ComboBox FilterOptions_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.DataGridView Facturas_dataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button ShowFactura_btn;
        private System.Windows.Forms.Label label4;
    }
}