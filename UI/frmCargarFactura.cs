using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmCargarFactura : Form
    {
        private readonly List<BE.Prestador> prestadores = new List<BE.Prestador>();

        private int puntoVenta;
        private int numeroFactura;
        private DateTime fechaIngreso = DateTime.Now;
        private DateTime fechaFactura = DateTime.Now;
        private float monto;
        private string observaciones = "";

        public frmCargarFactura(List<BE.Prestador> prestadores)
        {
            InitializeComponent();
            this.prestadores = prestadores;
            ChargePrestadores(prestadores);
            SetDateTimes();
        }

        void ChargePrestadores(List<BE.Prestador> list)
        {
            Prestadores_dataGridView.DataSource = null;
            Prestadores_dataGridView.DataSource = list;
            ConfigDataGridView();
        }

        void ConfigDataGridView()
        {
            Prestadores_dataGridView.Columns[0].Visible = false;
            Prestadores_dataGridView.Columns[3].Visible = false;

            Prestadores_dataGridView.Columns[2].HeaderText = "Punto de Venta";

            Prestadores_dataGridView.Columns[1].Width = 300;
            Prestadores_dataGridView.Columns[2].Width = 105;
        }

        private void FiltPrestadores_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PrestadorName_textBox.Text))
            {
                // Filtrar lista de prestadores según el nombre otorgado.
                List<BE.Prestador> filteredList = new List<BE.Prestador>();
                prestadores.ForEach(p =>
                {
                    if (p.Nombre.Contains(PrestadorName_textBox.Text.ToUpper()))
                    {
                        filteredList.Add(p);
                    }
                });
                ChargePrestadores(filteredList);
            }
            else MessageBox.Show("Ingresa un nombre para filtrar la lista.");
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            ChargePrestadores(prestadores);
        }

        // Error Message Label
        private void ShowErrorMessage(bool visible, string message = "")
        {
            ErrorMessage_label.Visible = visible;
            ErrorMessage_label.Text = message;
        }

        // Punto de venta
        private void PuntoVenta_textBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PuntoVenta_textBox.Text))
            {
                puntoVenta = int.Parse(PuntoVenta_textBox.Text);
            }
        }

        private void PuntoVenta_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PuntoVenta_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PuntoVenta_checkBox.Checked == true)
            {
                PuntoVenta_textBox.Text = "";
                PuntoVenta_textBox.Enabled = false;
                puntoVenta = 0;
            } else
            {
                PuntoVenta_textBox.Enabled = true;
            }
        }
        
        // Número de la factura
        private void Numero_textBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Numero_textBox.Text))
            {
                int result = int.Parse(Numero_textBox.Text);
                if (result != 0)
                {
                    numeroFactura = result;
                    if (ErrorMessage_label.Visible) ShowErrorMessage(false);
                }
                else ShowErrorMessage(true, "El numero de factura no es valido.");
            } else ShowErrorMessage(false);

        }

        private void Numero_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Fecha de recepcion

        private void SetDateTimes()
        {
            FechaFactura_dateTimePicker.MaxDate = DateTime.Now;
            FechaRecepcion_dateTimePicker.MinDate = FechaFactura_dateTimePicker.Value;
        }

        private void FechaRecepcion_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SetDateTimes();
        }

        // Fecha de emision de la factura
        private void FechaFactura_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SetDateTimes();
        }

        // Monto
        private void Monto_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Monto_numericUpDown.Value > 0)
            {
                monto = (float)Monto_numericUpDown.Value;
                if (ErrorMessage_label.Visible) ShowErrorMessage(false);
            }
            else ShowErrorMessage(true, "¡El monto de la factura debe ser mayor que cero!");
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadFactura_button_Click(object sender, EventArgs e)
        {
            if (Prestadores_dataGridView.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(Prestadores_dataGridView.SelectedRows[0].Cells["id"].Value);
                BE.Prestador selectedPrestador = prestadores.Find(p => p.ID == id);

                if (!PuntoVenta_checkBox.Checked && puntoVenta == 0)
                {
                    if (numeroFactura > 0)
                    {
                        if (Monto_numericUpDown.Value > 0)
                        {
                            BE.Factura nuevaFactura = new BE.Factura(
                                selectedPrestador,
                                puntoVenta,
                                numeroFactura,
                                fechaFactura,
                                fechaIngreso,
                                monto,
                                observaciones);
                        }
                        else ShowErrorMessage(true, "El monto invalido.");
                    }
                    else ShowErrorMessage(true, "Es necesario proporcionar un numero de factura para continuar.");
                }
                else ShowErrorMessage(true, "Es necesario proporcionar un punto de venta para continuar.");
            }
            else ShowErrorMessage(true, "Es necesario elegir un prestador para continuar.");
        }

        private void ResetInputs_button_Click(object sender, EventArgs e)
        {
            PrestadorName_textBox.Text = string.Empty;
            Observaciones_textBox.Text = string.Empty;
            PuntoVenta_checkBox.Checked = false;
            PuntoVenta_textBox.Text = string.Empty;
            Numero_textBox.Text = string.Empty;
            Monto_numericUpDown.Value = 0;
            FechaFactura_dateTimePicker.Value = DateTime.Now;
            FechaRecepcion_dateTimePicker.Value = DateTime.Now;
        }

        private void Prestadores_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
